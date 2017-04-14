using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDUpdate : MonoBehaviour {

[SerializeField]
Text score;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		score.text = string.Format("Target Threshold:{0}", AdSpawner.killLimit - AdSpawner.currentKills);
	}
}
