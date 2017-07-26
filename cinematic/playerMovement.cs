using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

	float runSpeed=10f;
	Vector3 movement;
	float h;//horizontal
	float v;//vertical
	Animator myAnim;
	Rigidbody myRb;
	bool inEvent=false;
	[SerializeField] int pointCount;


	// Use this for initialization
	void Awake () {
		myAnim = GetComponent<Animator> ();
		myRb = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	// FixedUpdate called at a certain time
	void FixedUpdate () {

		if (!inEvent) {
			h = Input.GetAxisRaw ("Horizontal"); // left or right
			v = Input.GetAxisRaw ("Vertical"); // up n down or w s keys
		} else {
			h = 0;
			v = 0;

		}
		Move(h, v);
		Animate (h, v);
	}

	void Animate(float h, float v){
		bool running = h !=0f || v !=0f;
		myAnim.SetBool ("isRunning", running);
	}

	public void toggleEvent(){
		inEvent = !inEvent;

	}
	public void incrementPointCount(){
		pointCount++;

	}

	public void getReward(){
		toggleEvent ();
		myAnim.SetTrigger ("reward");
	}
	void Move(float h, float v){
		movement.Set (h, 0f, v);

		if(h!=0 || v!=0){
			myRb.MoveRotation(Quaternion.LookRotation(movement));
		}
		movement=movement.normalized * runSpeed * Time.deltaTime;

		myRb.MovePosition(transform.position + movement);
  }
}
