using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class TransitionToNewScene : MonoBehaviour 
{
	[SerializeField]
	private string sceneName;
	public void LoadScene()
	{
		SceneManager.LoadScene(sceneName);
	}

}
