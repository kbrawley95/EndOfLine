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
	void Start ()
	 {
		Setup();
		emailInstances = new List<GameObject>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Test: If space key is pressed,change email queue positions
		if(Input.GetKey(KeyCode.Space))
			MoveForward();
	}
	
	/*Method that handles the initialisation of scene objects, and adds new email instances to designated list*/
	void Setup()
	{
		for(int i = 0; i<emails.Length; i++)
		{
			GameObject email = GameObject.Instantiate(emails[i], queuePositions[i].transform.position, Quaternion.identity, parent.transform);
			email.transform.GetChild(0).GetComponent<Text>().text = emailContents[i];
			emailInstances.Add(email);
		}
	}

	/*Method that alters the position of emails in the queue if they are swiped out of screen */
	void MoveForward()
	{
		for(int i = 0; i<emailInstances.Count; i++)
		{
			emailInstances[i].transform.position = queuePositions[i + 1].transform.position;
			if(i == 3)
				i = -1;
		}
	}

	/*Method that handles the manipulation of email entries based on touch input */
	void Swipe()
	{
		
	}
}
