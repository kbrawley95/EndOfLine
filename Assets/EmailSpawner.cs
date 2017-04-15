using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmailSpawner : MonoBehaviour {

	[SerializeField]
	GameObject[] emails;
	[SerializeField]
	List <GameObject> emailInstances;

	[SerializeField]
	GameObject[] queuePositions;

	[SerializeField]
	GameObject parent;

	[SerializeField]
	string[] emailContents;

	// Use this for initialization
	void Start () {
		Setup();
		emailInstances = new List<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Space))
			MoveForward();
	}
	
	void Setup()
	{
		for(int i = 0; i<emails.Length; i++)
		{
			GameObject email = GameObject.Instantiate(emails[i], queuePositions[i].transform.position, Quaternion.identity, parent.transform);
			email.transform.GetChild(0).GetComponent<Text>().text = emailContents[i];
			emailInstances.Add(email);
		}
	}

	void MoveForward()
	{
		for(int i = 0; i<emailInstances.Count; i++)
		{
			emailInstances[i].transform.position = queuePositions[i + 1].transform.position;
			if(i == 3)
				i = -1;
		}
	}
}
