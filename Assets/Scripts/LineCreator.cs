using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCreator : MonoBehaviour {
	
	[SerializeField]
	GameObject player;
	// Use this for initialization	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < TouchManager.TouchCount(); ++i)
		{
			if (TouchManager.GetTouch(i).phase.Equals(TouchPhase.Began))
			{
				RaycastHit hit;
				Ray ray = Camera.main.ScreenPointToRay(TouchManager.GetTouch(i).position);
				if(Physics.Raycast(ray, out hit))
				{
					player.transform.SetPositionAndRotation(hit.point, Quaternion.identity);	
				}
			}
		}
	}

}



    


