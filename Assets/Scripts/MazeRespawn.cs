 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeRespawn : MonoBehaviour {

	[SerializeField]
	GameObject startPosition;

	void OnTriggerEnter(Collider other)
	{
		//If player collides with falls into box collider, respawn at beginning
		if(other.gameObject.name == "Player")
		{
			other.gameObject.transform.position = startPosition.gameObject.transform.position;
		}
	}
}
