using UnityEngine;
using System.Collections;

public class enemySpawner : MonoBehaviour {

	public GameObject[] enemy;
	public float maxPos = 2.2f;
	float timer;
	public float delayTimer = 1f;
	int enemyNumber;

	// Use this for initialization
	void Start () {
		timer = delayTimer;
	}

	// Update is called once per frame
	void Update () {

		timer -= Time.deltaTime;
		if (timer <= 0) {
			Vector3 enemyPos = new Vector3 (Random.Range (-2.2f, 2.2f), transform.position.y, transform.position.z);
			enemyNumber = Random.Range (0, 5);
			Instantiate (enemy[enemyNumber], enemyPos, transform.rotation);
			timer = delayTimer;
		}
	}
}
