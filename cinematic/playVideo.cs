using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(AudioSource))]

public class playVideo : MonoBehaviour {

	[SerializeField]MovieTexture movie;
	Renderer myRenderer;

	// Use this for initialization
	void Start () {
		myRenderer = GetComponent<Renderer> ();
		movie.Stop ();
		myRenderer.material.mainTexture = movie;
		movie.Play ();
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			movie.Stop ();
			myRenderer.material.mainTexture = movie;
			movie.Play ();
		}
	}
}
