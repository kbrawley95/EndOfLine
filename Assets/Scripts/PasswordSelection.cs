using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasswordSelection : MonoBehaviour {

	[SerializeField]
	GameObject passwordText;
	[SerializeField]
	Vector3 currentPosition;
	public static Vector3 hitPosition;

	void Update ()
	{
		for (int i = 0; i < TouchManager.TouchCount(); ++i)
		{
			if (TouchManager.GetTouch(i).phase.Equals(TouchPhase.Began))
			{
				//Construct a ray from the current touch coordinates
				RaycastHit hit;
				Ray ray = Camera.main.ScreenPointToRay(TouchManager.GetTouch(i).position);
				if (Physics.Raycast(ray, out hit))
				{
					//Destroy the first game object hit by ray
					if(hit.collider.gameObject.tag=="Password")	
					{
						hitPosition = hit.point;
						currentPosition = hitPosition;
						passwordText.SetActive(true);
						Scoreboard.currentScore +=5;
						hit.collider.gameObject.SetActive(false);
						TransitionToNewScene.LoadScene("Secure The Server");
					}
				}
			}
		}
	}
}
