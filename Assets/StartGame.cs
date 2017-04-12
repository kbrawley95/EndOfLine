using UnityEngine;

public class StartGame : MonoBehaviour {

	[SerializeField]
	GameObject audioManager;
	// Use this for initialization
	public void Init()
	{
		audioManager.SetActive(true);
		TransitionToNewScene.LoadScene(SceneRandomiser.SelectNextScene());
	}
	
}
