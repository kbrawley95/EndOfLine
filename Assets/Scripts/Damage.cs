using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour {

	[SerializeField]
	GameObject respawnPoint;

	// Use this for initialization

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.name == "Player")
		{
			other.gameObject.transform.position = respawnPoint.transform.position;
		}
	}
}
