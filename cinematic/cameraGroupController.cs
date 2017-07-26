using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraGroupController : MonoBehaviour {

	[SerializeField] GameObject theCamera;
	Animator rotationGroupAnim;
	Vector3 cameraOriginPos;

	// Use this for initialization
	void Start () {
		rotationGroupAnim = GetComponentInChildren<Animator> ();
		cameraOriginPos = theCamera.transform.localPosition;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void arcShot(){
		rotationGroupAnim.SetTrigger ("arcShot");
	}
}
