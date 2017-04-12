using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

	private static AudioManager manager = null;
	public static AudioManager Manager
	{
		get {return Manager;}
	}

	void Awake()
	{
		if(manager != null && manager !=this)
		{
			Destroy(this.gameObject);
			return;
		}
		else
		{
			manager = this;
		}
		DontDestroyOnLoad(this.gameObject);
	}

	//DO SOMETHING ELSE
}
