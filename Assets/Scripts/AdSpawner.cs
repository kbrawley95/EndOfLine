﻿using System.Collections.Generic;
using UnityEngine;
public class AdSpawner : MonoBehaviour {


[SerializeField]
int killCount;
[SerializeField]
GameObject adPrefab;

[SerializeField]
GameObject poolObj;
[SerializeField]
List<GameObject> ad_pool;

[SerializeField]
Vector2[] adPositions;


	void Start()
	{
		killCount = 0;
		SetupAds();
	}
	void Update () 
	{
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

	
}
