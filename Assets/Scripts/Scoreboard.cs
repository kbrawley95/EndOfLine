using UnityEngine;

public class Scoreboard : MonoBehaviour {
	private Scoreboard score = null;
	public Scoreboard Score
	{
		get {return score;}
	}

	[SerializeField]
	int tempScore;

	[SerializeField]
	int tries = 0;
	public static int currentScore =0;

	public static int currentTries = 0;

	[SerializeField]


	void Awake()
	{
		currentScore = 0;
		if(score != null && score !=this)
		{
			Destroy(this.gameObject);
			return;
		}
		else
		{
			score = this;
		}
		DontDestroyOnLoad(this.gameObject);
	}
	
	// Update is called once per frame
	void Update () 
	{
		tempScore = currentScore;

		if(currentTries == 3)
		{
			TransitionToNewScene.LoadScene("Final Score");
		}	
		
	}
}
