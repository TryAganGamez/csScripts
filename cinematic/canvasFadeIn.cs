using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvasFadeIn : MonoBehaviour {

	bool fadeIn = false;
	CanvasGroup myGroup;

	// Use this for initialization
	void Start () {
		myGroup = GetComponent<CanvasGroup> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (fadeIn)
			myGroup.alpha = Mathf.Lerp (myGroup.alpha, 1f, Time.deltaTime);

	}
	public void setFadeIn(){

		fadeIn = true;
	}
}
