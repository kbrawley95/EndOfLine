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
				if(other.gameObject.GetComponent<Answer>().GetAnswer() == true)
				{
					Debug.Log("Real");
					Scoreboard.currentScore +=5;
					
				}
				else
				{
					Debug.Log("False Positive");
					Scoreboard.currentScore -=10;
				}
				
			}
			else if(gameObject.name == "Fake")
			{
				if(other.gameObject.GetComponent<Answer>().GetAnswer() == false)
				{
					Debug.Log("Fake");
					Scoreboard.currentScore +=5;
				}
				else
				{
					Debug.Log("False Positive");
					Scoreboard.currentScore -=10;
				}
			}

			Destroy(other.gameObject);
			EmailSpawner.emailCount --;
		}
	}

}
