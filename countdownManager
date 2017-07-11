using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class countdownTimer : MonoBehaviour {

	public float timeLeft = 300.0f;
	public Text countDownText;
	public float waitForSeconds=0f; 
	uiManager dieCommand;


	// Use this for initialization
	void Start () {
		dieCommand = FindObjectOfType<uiManager> ();	
		
	}
	
	// Update is called once per frame
	void Update () {

		timeLeft -= Time.deltaTime;
		countDownText.text = "Time Left: " + Mathf.Round (timeLeft);
		if (timeLeft < 0) {
			timeLeft = 0;
			dieCommand.GameOver ();
			//Load a UiManager 
			//SceneManager.LoadScene("one");
			//StartCoroutine ("Wait");

		}
	}
}
/*	IEnumerator Wait(){
		yield return new WaitForSeconds(5);
			SceneManager.LoadScene ("one");

	}
}**/
