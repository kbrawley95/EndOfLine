using UnityEngine;

public class StartGame : MonoBehaviour {

	[SerializeField]
	GameObject audioManager;

	void Update()
	{
		if(CountdownTimer.clock.text == "Time: 0")
		{
			Screen.orientation = ScreenOrientation.LandscapeRight;
			audioManager.SetActive(true);
		}
	}
}
