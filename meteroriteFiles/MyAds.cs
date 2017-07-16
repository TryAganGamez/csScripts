using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class MyAds : MonoBehaviour {

	public uiManager ui;

	// Use this for initialization
	void Start () {
	
		Advertisement.Initialize ("1219684", false);
		StartCoroutine (ShowAdWhenReady ());

	}
	IEnumerator ShowAdWhenReady (){
		while (!Advertisement.IsReady ())
			yield return null;

		Advertisement.Show ();
	}
	void Exit(){
		Advertisement.Show ();
		ui.Exit ();
}
}