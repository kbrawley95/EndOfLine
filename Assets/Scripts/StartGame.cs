using UnityEngine;

public class StartGame : MonoBehaviour {

	[SerializeField]
	GameObject audioManager;
	[SerializeField]
	GameObject scoreboard;

	void Update()
	{
		if(CountdownTimer.clock.text == "Time: 1")
		{
			Screen.orientation = ScreenOrientation.LandscapeRight;
			audioManager.SetActive(true);
			scoreboard.SetActive(true);
		}
	}
}
