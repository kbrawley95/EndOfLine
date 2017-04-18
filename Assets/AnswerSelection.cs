using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerSelection : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "Email")
		{
			if(gameObject.name == "Real")
			{
				Debug.Log("Real");
				Destroy(other.gameObject);
			}
			else if(gameObject.name == "Fake")
			{
				Debug.Log("Fake");
				Destroy(other.gameObject);
			}
		}
	}
}
