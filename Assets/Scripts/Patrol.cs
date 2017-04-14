using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour {

	[SerializeField]
	Transform[] waypoints;

	[SerializeField]
	float speed;
	int current;
	Vector3 heading = Vector3.zero;
	
	[SerializeField]
	float distance = 0.0f;
	Vector3 direction = Vector2.zero;

	Vector3 newPosition;
	// Use this for initialization
	void Start () 
	{
		current = 0;
		gameObject.transform.position = waypoints[1].transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		heading = waypoints[current].position - gameObject.transform.position;
		distance = heading.magnitude;
		direction = heading/distance;//Normalised

		if(distance < 0.1f)
        {
            current++;
            if (current >= waypoints.Length)
                current = 0;
        }

		gameObject.transform.Translate(direction * speed * Time.deltaTime);
		
	}
}
