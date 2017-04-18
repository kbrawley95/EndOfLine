using UnityEngine;

public class EmailMovement : MonoBehaviour
{
	public Vector2 movment_amount = new Vector2(14, 11);

	[SerializeField]
	float speed = 1;

	private GameObject 	moving_object = null;
	private Vector3 	current_object_pos = Vector3.zero;
	private Vector2 	mouse_position = Vector2.zero;

	//Update is called once per frame
	void Update ()
	{
		for (int i = 0; i < TouchManager.TouchCount(); ++i)
		{
			if (TouchManager.GetTouch(i).phase.Equals(TouchPhase.Began))
			{
				//Construct a ray from the current touch coordinates
				Vector2 origin = Camera.main.ScreenToWorldPoint(TouchManager.GetTouch(i).position);
				RaycastHit2D hit = Physics2D.Raycast(origin, (TouchManager.GetTouch(i).position));
				if (hit.collider !=null)
				{
					Debug.Log("Hit");
					//Store variables
					moving_object = hit.collider.gameObject;
					current_object_pos = moving_object.transform.position;
					mouse_position = TouchManager.GetTouch(i).position;
				}
				else
					moving_object = null;
			}
			else if(TouchManager.GetTouch(i).phase.Equals(TouchPhase.Moved))
			{
				if (moving_object != null)
				{
					//Get Mouse Movment
					Vector2 converted_mouse = (TouchManager.GetTouch(i).position - mouse_position);
					//Used to measure how much right the user has dragged
					float transparency = Mathf.Abs((converted_mouse.x - (Screen.width / 2)) / Screen.width);
					//Convert screen to world space
					converted_mouse.x = (converted_mouse.x / Screen.width) * movment_amount.x;
					converted_mouse.y = (converted_mouse.y / Screen.height) * movment_amount.y;
					//Apply position to object
					moving_object.transform.position = current_object_pos + new Vector3(converted_mouse.x * speed, converted_mouse.y, 0);
					// gameObject.GetComponent<Rigidbody2D>().position = current_object_pos + new Vector3(converted_mouse.x, converted_mouse.y, 0);

					//Extra feature
					Renderer rend = moving_object.GetComponent<Renderer>();
					if (rend)
					{
						//Right edge transparency = 0, left edge = 1
						Debug.Log(transparency);
					}
				}
			}
			else if (TouchManager.GetTouch(i).phase.Equals(TouchPhase.Ended))
			{
				moving_object = null;
			}
		}
	}
}