using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneRandomiser : MonoBehaviour {

	[SerializeField]
	List<string> scenes;
	[SerializeField]
	static List<string> openScenes = new List<string>();
	[SerializeField]
	static List<string> closedScenes = new List<string>();

	void Start()
	{
		foreach(string s in scenes)
		{
			openScenes.Add(s);
		}
	}
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

	public static string GetOpenScene(int index)
	{
		return openScenes[index];
	}
}
