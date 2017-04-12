using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneRandomiser : MonoBehaviour {

	[SerializeField]
	static List<string> openScenes;
	[SerializeField]
	static List<string> closedScenes;

	// Use this for initialization
	public static string SelectNextScene()
	{	
		string temp = "";
		int randomiser = Random.Range(0, openScenes.Count - 1);
		temp = openScenes[randomiser];
		return temp;
	}

	public static void AddSceneToClosedList(string scene)
	{
		closedScenes.Add(scene);
		openScenes.Remove(scene);
	}

	public static void AddSceneToOpenList(string scene)
	{
		openScenes.Add(scene);
		closedScenes.Remove(scene);
	}
}
