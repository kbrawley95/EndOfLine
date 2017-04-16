using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour {

[SerializeField]
Text score;
[SerializeField]
Text remainingLives;

	// Use this for initialization
	void Start () {
		score.text = " " + Scoreboard.currentScore;
		remainingLives.text = " " + Scoreboard.currentTries;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
