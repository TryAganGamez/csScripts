using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeWalls : MonoBehaviour {

	Renderer myRenderer;
	bool fadeOut = false;

	// Use this for initialization
	void Start () {
		myRenderer = GetComponentInChildren < Renderer> ();

		
	}
	
	// Update is called once per frame
	void Update () {

		if(fadeOut){
			myRenderer.material.color = Color.Lerp(myRenderer.material.color,new Color(1f,1f,1f,0.25f),5*Time.deltaTime);
				}else{
			myRenderer.material.color = Color.Lerp(myRenderer.material.color,new Color(1f,1f,1f,1f),5*Time.deltaTime);		
		}
}

						void OnTriggerEnter(Collider other){
		if (other.tag == "MainCamera")
			fadeOut = true;

						}
	void OnTriggerExit(Collider other){
		if (other.tag == "MainCamera")
			fadeOut = false;
	}
}
