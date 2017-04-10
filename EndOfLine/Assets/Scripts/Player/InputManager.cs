using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {
[SerializeField]
private float jumpSpeed = 4.0f;
[SerializeField]
private float forwardSpeed = 3.0f;
private float absVelX = 0f;
[SerializeField]
private float absVelY = 0f;
[SerializeField]
private bool isStanding = true;
[SerializeField]
private bool isIdle = true;
private float standingThreshold = 1.0f;
[SerializeField]
private float moveThreshold = 1.0f;
[SerializeField]
private Rigidbody rigidbody;

	
	void Awake(){
		rigidbody = GetComponent<Rigidbody>();
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		bool jump = Input.GetKeyDown(KeyCode.Space);
		
		var right =Input.GetAxis("Horizontal") * Time.deltaTime * 6.0f;

		if(isStanding)
		{
			if(jump)
			 rigidbody.velocity = new Vector2(transform.position.x < 0 ? forwardSpeed : 0, jumpSpeed);

			 transform.Translate(right,0,0);
		}

		

	}

	void FixedUpdate()
    {
        absVelX = Mathf.Abs(rigidbody.velocity.x);
        absVelY = Mathf.Abs(rigidbody.velocity.y);

        isStanding = absVelY <= standingThreshold;

    }
}
