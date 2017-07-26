using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class introMovement : MonoBehaviour {

	Rigidbody myRb;
	float moveSpeed = 1.6f;

	// Use this for initialization
	void Start () {
		myRb = GetComponent<Rigidbody> ();
		myRb.velocity = new Vector3 (moveSpeed, 0, 0);
	}

}
