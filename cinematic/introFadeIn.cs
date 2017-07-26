using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class introFadeIn : MonoBehaviour {

	public Canvas eventCanvas;

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			eventCanvas.GetComponent<canvasFadeIn> ().setFadeIn ();
			StartCoroutine (loadGame ());

		}
	}
	IEnumerator loadGame(){
		yield return new WaitForSeconds(5);
		SceneManager.LoadScene("two");
	}
}
