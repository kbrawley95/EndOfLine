using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Passwords : MonoBehaviour {

	[SerializeField]
	string[] passwords;

	[SerializeField]
	bool[] isStrong;

	[SerializeField]
	GameObject[] answers;

	[SerializeField]
	List <int> usedPasswords;

	// Use this for initialization
	void Start () 
	{
		usedPasswords = new List<int>();

		for(int i=0; i<answers.Length; i++)
		{
			int numRand = Random.Range(0, passwords.Length - 1);
			
			do
			{
				numRand = Random.Range(0, (passwords.Length - 1));
			} 
			while(usedPasswords.Contains(numRand));

			answers[i].transform.GetChild(0).GetComponent<Text>().text = passwords[numRand];
			usedPasswords.Add(numRand);
			Debug.Log("Done");
		}
	}
	
}
