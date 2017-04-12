using UnityEngine;

public class Test : MonoBehaviour
{
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
					Destroy(hit.collider.gameObject);
				}
			}
		}
	}
}