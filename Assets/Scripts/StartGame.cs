using UnityEngine;

public class StartGame : MonoBehaviour {

	[SerializeField]
	GameObject audioManager;
	[SerializeField]
	GameObject scoreboard;

	void Awake()
	{
		Screen.orientation = ScreenOrientation.LandscapeRight;
	}
	void Update()
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
					if(hit.collider.name == "Terminal")
					{
						audioManager.SetActive(true);
						scoreboard.SetActive(true);
						TransitionToNewScene.LoadScene(SceneRandomiser.SelectNextScene());
					}
				}
			}
		}
	}
}
