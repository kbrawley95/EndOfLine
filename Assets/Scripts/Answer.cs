using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answer : MonoBehaviour {

	[SerializeField]
	int indexPosition;

	[SerializeField]
	bool isReal = false;

	public void SetAnswer(bool value)
	{
		isReal = value;
	}

	public void SetIndexPosition(int value)
	{
		indexPosition = value;
	}

	public bool GetAnswer()
	{
		return isReal;
	}
	public  int GetIndexPosition()
	{
		return indexPosition;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
