﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AdSpawner : MonoBehaviour {

[SerializeField]
string sceneName;
[SerializeField]
GameObject adPrefab;

[SerializeField]
GameObject poolObj;
[SerializeField]
List<GameObject> ad_pool;

[SerializeField]
Vector2[] adPositions;

[SerializeField]	
Text clock;

[SerializeField]	
float timer;
Scene currentScene;

	void Start()
	{
		SetupAds();
		currentScene = SceneManager.GetActiveScene();
	}
	void Update () 
	{
		timer -=Time.deltaTime;
		clock.text = FormatedTime(timer);	

		if(timer <0)
		{
			timer = 0;
			SceneRandomiser.AddSceneToClosedList(currentScene.name);
			TransitionToNewScene.LoadScene(SceneRandomiser.SelectNextScene());
		}
	}

	void SetupAds()
	{
		for(int i =0; i<adPositions.Length; i++)
		{
			GameObject temp = GameObject.Instantiate(adPrefab, adPositions[i], Quaternion.identity, poolObj.transform);
			temp.GetComponent<RectTransform>().anchoredPosition=adPositions[i];
			ad_pool.Add(temp);
		}
	}

	string FormatedTime(float value)
	{
		string formated_time ="";
		float tenth_seconds = value % 1000;
		return formated_time = string.Format("Time: {0}", (int)tenth_seconds);
	}
}