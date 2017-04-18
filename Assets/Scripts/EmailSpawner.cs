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
	public static GameObject[] staticPositions;

	[SerializeField]
	GameObject parent;

	[SerializeField]
	string[] emailContents;

	[SerializeField]
	bool[] emailBools;

	public static int emailCount;

	[SerializeField]
	int numberOfEmails = 0;

	// Use this for initialization
	void Start ()
	 {
		Screen.orientation = ScreenOrientation.LandscapeRight;
		Setup();
		emailInstances = new List<GameObject>();
		staticPositions = queuePositions;
	}
	
	// Update is called once per frame
	void Update () 
	{
		numberOfEmails = emailCount;

		if(emailCount <1)
			TransitionToNewScene.LoadScene(SceneRandomiser.SelectNextScene());
	}
	
	/*Method that handles the initialisation of scene objects, and adds new email instances to designated list*/
	void Setup()
	{
		for(int i = 0; i<emails.Length; i++)
		{
			GameObject email = GameObject.Instantiate(emails[i], queuePositions[i].transform.position, Quaternion.identity, parent.transform);
			email.transform.GetChild(0).GetComponent<Text>().text = emailContents[i];
			email.GetComponent<Answer>().SetAnswer(emailBools[i]);
			// email.GetComponent<Answer>().SetIndexPosition(i);
			emailInstances.Add(email);
			emailCount++;
		}
	}

	void Spawn()
	{
		
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

}
