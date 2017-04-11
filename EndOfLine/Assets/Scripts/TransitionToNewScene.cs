using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class TransitionToNewScene : MonoBehaviour 
{
	[SerializeField]
	private static string sceneName;
	public static void LoadScene(string sceneName)
	{
		SceneManager.LoadScene(sceneName);
	}


}
