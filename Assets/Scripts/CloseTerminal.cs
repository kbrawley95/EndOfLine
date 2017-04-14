using UnityEngine;
using UnityEngine.UI;

public class CloseTerminal : MonoBehaviour
{
	[SerializeField]
	GameObject scoreText;
	public static Vector3 hitPoint;
	
	//Update is called once per frame
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
					if(hit.collider.gameObject.tag=="Terminal")	
					{
						hitPoint = hit.point;
						scoreText.SetActive(true);
						Scoreboard.currentScore +=5;
						AdSpawner.currentKills++;
						hit.collider.gameObject.SetActive(false);
					}
				}
			}
		}
	}
}