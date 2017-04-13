using UnityEngine;

public class EndGame : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.name == "Player")
		{
			Scoreboard.currentScore +=20;
			TransitionToNewScene.LoadScene(SceneRandomiser.SelectNextScene());
		}
	}
}
