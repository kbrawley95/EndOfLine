using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour {

	[SerializeField]
	Text HUD;
	[SerializeField]
	Text scoreText;
	
	Vector2 direction = new Vector2(0,1);
	Color initialColor;
	Color finalColor;

	float displayTime = 2.0f;

	void OnEnable()
	{
		StartCoroutine(FadeOut());
	}

	
	void Update()
	{
		if(scoreText.color.a < 0.2)
		{
			StopCoroutine(FadeOut());
			ResetValues();
			gameObject.SetActive(false);
		}
	}
	
	IEnumerator FadeOut()
	{
		//Set properties Values
		initialColor = scoreText.color;
		finalColor = initialColor;
		finalColor.a = 0;

		while(scoreText.color.a > 0)
		{
			//Appear at hit location
			gameObject.transform.position = CloseTerminal.hitPoint + new Vector3(0, 1.0f, 0);
			
			//Transistion between original color to new colour i.e. decrement aplha value to 0
			scoreText.color = Color.Lerp(scoreText.color, finalColor, displayTime * Time.deltaTime);
			Debug.Log(scoreText.color.a);

			 yield return null;
		}
		
	}
	void ResetValues()
	{
		scoreText.color = initialColor;
	}
}
