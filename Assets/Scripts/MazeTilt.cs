using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeTilt : MonoBehaviour {
	
	[SerializeField]
	GameObject player;

	[SerializeField]
	GameObject startingPoint;
	Vector3 direction = Vector3.zero;
	[SerializeField]
	float speed;
	
	// Update is called once per frame

	void Start()
	{
		player.transform.position = startingPoint.transform.position;
	}
	void Update () {
	
		direction.x = Input.acceleration.x;

		direction.x = Input.GetAxis("Horizontal");
		//direction.y -= Input.acceleration.y;

		//Clamp acceleration vector to the unity sphere
		if(direction.sqrMagnitude > 1)
			direction.Normalize();

		//Make it move 10 meters per second instead of 10 meters per frame
		direction *=Time.deltaTime;

		//Move object
		player.transform.Translate(direction * speed);

	}

}



    


