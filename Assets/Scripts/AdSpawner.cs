using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AdSpawner : MonoBehaviour {

[SerializeField]
int killCount;
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
		killCount = 0;
		SetupAds();
		currentScene = SceneManager.GetActiveScene();
	}
	void Update () 
	{
		timer -=Time.deltaTime;
		clock.text = FormatedTime(timer);	

		//If timer equals 0, triggers scene transition
		if(timer <0)
		{
			timer = 0;
			SceneRandomiser.AddSceneToClosedList(currentScene.name);
			TransitionToNewScene.LoadScene(SceneRandomiser.SelectNextScene());
		}

		//Checks Whether a pop-up object has been closed by player, relocates it and enables it once more
		RespawnAds();
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

	void RespawnAds()
	{
		foreach(GameObject g in ad_pool)
		{
			int randomNum = Random.Range(0, ad_pool.Count - 1);
			if(!g.activeSelf)
			{
				g.GetComponent<RectTransform>().anchoredPosition=adPositions[randomNum];
				g.SetActive(true);
			}
		}
	}

	string FormatedTime(float value)
	{
		string formated_time ="";
		float tenth_seconds = value % 1000;
		return formated_time = string.Format("Time: {0}", (int)tenth_seconds);
	}
}
