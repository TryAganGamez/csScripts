using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class uiManager : MonoBehaviour {

	public float highscoreCount;

	public Button[] buttons;
	public Text scoreText,highscoreText;
	int score;
	int highscore;
	bool gameOver;
	public AudioManager am;

	// Use this for initialization
	void Start () {
		if (PlayerPrefs.GetFloat ("Best") != null) {
			highscoreCount = PlayerPrefs.GetFloat ("Best");
		}

		gameOver = false;
		score = 0;
		highscore = PlayerPrefs.GetInt ("score",highscore);
		InvokeRepeating ("scoreUpdate", 1.0f, 0.5f);

	}

	// Update is called once per frame
	void Update () {
		if (score > highscoreCount) {
			highscoreCount = score;
			PlayerPrefs.SetFloat ("Best", highscoreCount);
		}
			
			scoreText.text = "Score: " + score;
		highscoreText.text = "Best: " + Mathf.Round (highscoreCount);



	}
	void scoreUpdate(){
		if (gameOver == false) {
			score += 1;

		}
	}

	public void gameOverActivated(){
		gameOver = true;
		foreach (Button button in buttons) {
			button.gameObject.SetActive(true);
		}
	}


	public void Play(){
		SceneManager.LoadScene ("one");	
	}

	public void Pause(){

		if (Time.timeScale == 1) {
			Time.timeScale = 0;
		} 
		else if (Time.timeScale == 0) {
			Time.timeScale = 1;
		}
	}
	public void Menu(){

		SceneManager.LoadScene ("menu");
	}
	public void Exit(){
		Application.Quit ();

	}
}