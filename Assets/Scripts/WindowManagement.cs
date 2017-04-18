using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowManagement : MonoBehaviour {
	
	[SerializeField]
	GameObject terminal;
	[SerializeField]
	bool inFocus = false;

	public void ToggleWindow()
	{
		inFocus =! inFocus;
	}

	public void CloseWindow()
	{
		inFocus = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		terminal.SetActive(inFocus);

	}
}
