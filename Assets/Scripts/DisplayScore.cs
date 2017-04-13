using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayScore : MonoBehaviour {

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private IEnumerator ShowScore()
	{
		gameObject.GetComponent<RectTransform>().anchoredPosition.y += (2 * Time.deltaTime);
		yield return new WaitForSeconds(2f);
	}
}
