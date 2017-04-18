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
	

	void Start()
	{
		//Set player start position (vector3)
		player.transform.position = startingPoint.transform.position;
	}
	void Update () {
		
		//Player direction on x-axis dependent on horizontal tilt of mobile (landscape)
		direction.x = Input.acceleration.x;

		//Clamp acceleration vector 
		if(direction.sqrMagnitude > 1)
			direction.Normalize();

		//Smooth interpolation of motion
		direction *=Time.deltaTime;

		//Move object
		player.transform.Translate(direction * speed);

	}

}



    


