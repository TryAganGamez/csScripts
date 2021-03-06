﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public Text scoreText;
	public Text highScoreText;
	public float scoreCount;
	public float highscoreCount;
	public float pointsPerSecond;
	public bool scoreIncreasing;


	// Use this for initialization
	void Start () {
		if (PlayerPrefs.GetFloat ("Best") != null) {
			highscoreCount = PlayerPrefs.GetFloat ("Best");
		}
	
	}
	
	// Update is called once per frame
	void Update () {
		if (scoreIncreasing) {
			scoreCount += pointsPerSecond * Time.deltaTime;
		}
		if (scoreCount > highscoreCount) {
			highscoreCount = scoreCount;
			PlayerPrefs.SetFloat ("Best", highscoreCount);
		}
		scoreText.text = "Score: " + Mathf.Round (scoreCount);
		highScoreText.text = "Best: " + Mathf.Round (highscoreCount);
	}
}
