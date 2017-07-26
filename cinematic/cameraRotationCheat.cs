using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraRotationCheat : MonoBehaviour {

	[SerializeField] Transform target;
	[SerializeField] float smoothing = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Quaternion rot = Quaternion.LookRotation (target.position - transform.position);
		transform.rotation = Quaternion.RotateTowards (transform.rotation, rot, smoothing * Time.deltaTime);
	}
}
