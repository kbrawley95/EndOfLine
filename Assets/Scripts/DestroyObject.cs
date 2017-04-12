using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour 
{
	// Use this for initialization
	bool isClicked = false;
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		for (var i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase.Equals(TouchPhase.Began))
            {
                // Construct a ray from the current touch coordinates
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
                if (Physics.Raycast(ray, out hit))
                {
                    //Destroy the object this script is attached to
                    Destroy(hit.collider.gameObject);
                }
            }
        }
	}

}


