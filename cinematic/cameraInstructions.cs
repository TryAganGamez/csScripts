using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraInstructions : MonoBehaviour {

	public GameObject theCamera;
	public Vector3 location;
	public Vector3 rotation;
	public float FOV;

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			introCamControl theInstruction = theCamera.GetComponent<introCamControl> ();
			theInstruction.updateLocation (location);
			theInstruction.setFOV (FOV);
		}

	}
}
