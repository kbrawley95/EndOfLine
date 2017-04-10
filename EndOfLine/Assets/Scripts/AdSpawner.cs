using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdSpawner : MonoBehaviour {

[SerializeField]
GameObject adPrefab;

[SerializeField]
GameObject poolObj;
[SerializeField]
List<GameObject> ad_pool;

[SerializeField]
Vector3[] adPositions;

[SerializeField]	
Text clock;

[SerializeField]	
float timer;

	void Start()
	{
		SetupAds();
	}
	void Update () 
	{
		timer -=Time.deltaTime;
		clock.text = FormatedTime(timer);	

		if(timer <0)
			timer = 0;
	}

	void SetupAds()
	{
		const int LIMIT = 6;
		for(int i =0; i<LIMIT; i++)
		{
			GameObject temp = GameObject.Instantiate(adPrefab, adPositions[i], Quaternion.identity);
			temp.transform.parent = poolObj.transform;
			temp.GetComponent<RectTransform>().SetPositionAndRotation(adPositions[i], Quaternion.identity);
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
