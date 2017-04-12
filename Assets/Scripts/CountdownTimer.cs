using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour {

	[SerializeField]
	float timerValue;

	[SerializeField]
	Text clockObj;
	public static float timer; 
	public static Text clock;


	Scene currentScene;

	// Use this for initialization
	void Start () {
		timer = timerValue;
		clock = clockObj;
		currentScene = SceneManager.GetActiveScene();
	}
	
	// Update is called once per frame
	void Update () {
		timer -=Time.deltaTime;
		clock.text = FormatedTime(CountdownTimer.timer);	

		//If timer equals 0, triggers scene transition
		if(CountdownTimer.timer <0)
		{
			CountdownTimer.timer = 0;
			SceneRandomiser.AddSceneToClosedList(currentScene.name);
			TransitionToNewScene.LoadScene(SceneRandomiser.SelectNextScene());
		}

	}

	public static string FormatedTime(float value)
	{
		string formated_time ="";
		float tenth_seconds = value % 1000;
		return formated_time = string.Format("Time: {0}", (int)tenth_seconds);
	}
}
