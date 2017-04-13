using UnityEngine;

public class Scoreboard : MonoBehaviour {
	private Scoreboard score = null;
	public Scoreboard Score
	{
		get {return score;}
	}

	[SerializeField]
	int tempScore;
	public static int currentScore;


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
	void Update () {
		tempScore = currentScore;
	}
}
