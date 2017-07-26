using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class introCamControl : MonoBehaviour {

	public void updateLocation(Vector3 loc){

		transform.position = loc;
	
	}
	public void updateRotation(Vector3 rot){
		transform.rotation = Quaternion.Euler (rot);

	}
	public void setFOV(float FOV){

		GetComponent<Camera> ().fieldOfView = FOV;
}
}