using UnityEngine;
using System.Collections;

public class playerMove : MonoBehaviour {

	public float playerSpeed;
	Vector3 position;
	public float maxPos = 2.2f;
	public uiManager ui;
	bool currentPlatformAndroid;
	Rigidbody2D rb;
	public AudioManager am;
	//public int highscore;

	void Awake(){
	//	am.player.Play ();
		rb = GetComponent<Rigidbody2D> ();
		#if UNITY_ANDROID
		currentPlatformAndroid = true;
		#else
		currentPlatformAndroid = false;
		#endif

	}
	// Use this for initialization
	void Start () {

		position = transform.position;
	}

	// Update is called once per frame
	void Update () {
		if (currentPlatformAndroid == true) {
			//android specific code
			//	TouchMove();
			AccellerometerMove();

		} else {

			position.x += Input.GetAxis ("Horizontal") * playerSpeed * Time.deltaTime;
			position.x = Mathf.Clamp (position.x, -2.2f, 2.2f);

			transform.position = position;
		}
		position = transform.position;
		position.x = Mathf.Clamp (position.x, -2.2f, 2.2f);
		transform.position = position;

	}
	void OnCollisionEnter2D(Collision2D col){

		if (col.gameObject.tag == "Enemy") {
			am.explode.Play ();
			Destroy (gameObject);
			ui.gameOverActivated ();
		}
	}

	void AccellerometerMove(){
		//stores x value in mem 
		float x = Input.acceleration.x;
		if (x < -0.1f) {
			MoveLeft ();
		} else if (x > 0.1f) {
			MoveRight ();
		} else {
			SetVelocityZero ();
		}

	}

	void TouchMove(){

		if (Input.touchCount > 0) {
			Touch touch = Input.GetTouch (0);
			float middle = Screen.width / 2;
			if (touch.position.x < middle && touch.phase == TouchPhase.Began) {
				MoveLeft ();

			}
			if (touch.position.x > middle && touch.phase == TouchPhase.Began) {
				MoveRight ();
			}
		} else {

			SetVelocityZero ();
		}
	}

	public void MoveLeft(){
		rb.velocity = new Vector2 (-playerSpeed, 0);

	}
	public void MoveRight(){
		rb.velocity = new Vector2 (playerSpeed, 0);

	}
	public void SetVelocityZero(){
		rb.velocity = Vector2.zero;

	}
}
