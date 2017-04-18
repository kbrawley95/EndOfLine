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
	void Start () 
	{
		//Final score & lives used equal to values held in scoreboard class during session
		score.text = " " + Scoreboard.currentScore;
		remainingLives.text = " " + (3 - Scoreboard.currentTries);
	}
	
	
}
