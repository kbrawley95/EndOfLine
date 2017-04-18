using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDUpdate : MonoBehaviour {

[SerializeField]
Text score;
	
	// Update is called once per frame
	void Update () 
	{
		//Remaining number of enemies player has to destroy updated in real-time & displayed in UI
		score.text = string.Format("Target Threshold: {0}", AdSpawner.killLimit - AdSpawner.currentKills);
	}
}
