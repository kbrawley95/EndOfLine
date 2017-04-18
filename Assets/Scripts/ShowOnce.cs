using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowOnce : MonoBehaviour {

	[SerializeField]
	bool firstTime = true;

	[SerializeField]
	bool blink = false;

	[SerializeField]
	float speed = 2.0f;
	Color initialColor;
	Color finalColor;
	[SerializeField]
	Text targetText;
	// Use this for initialization
	void Start () {

		//Assign the final color the same color as our target, and alter its alpha value to 0
		initialColor = targetText.color;
		finalColor = initialColor;
		finalColor.a = 0;
		
		if(firstTime)
		{
			StartCoroutine(FadeOut());
		}
			
	}
	
	// Update is called once per frame
	void Update () {
		//If the text is no longer visible, stop script
		if(targetText.color.a <0.2)
		{
			targetText.color = initialColor;
			StopCoroutine(FadeOut());
			firstTime = false;
			gameObject.SetActive(false);
		}
	}

	//Alter the alpha value of the text colour over given amount of time i.e (make it invisible after few seconds)
	IEnumerator FadeOut()
	{
		while(targetText.color.a > 0)
		{
			targetText.color = Color.Lerp(targetText.color, finalColor, Time.deltaTime * speed);
			yield return null;
		}
	}

}
