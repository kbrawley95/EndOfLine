using UnityEngine;

public class TouchManager 
{
    public static Touch GetTouch(int id)
    {
        #if UNITY_EDITOR
            Touch mouse = new Touch();
            mouse.position  = Input.mousePosition;
            if (Input.GetKeyDown(KeyCode.Mouse0))
                mouse.phase = TouchPhase.Began;
            else if (Input.GetKeyUp(KeyCode.Mouse0))
                mouse.phase = TouchPhase.Ended;
            else
                mouse.phase = TouchPhase.Moved;

            //TODO Can add more mouse stuff here if you like
            return mouse;
        #else
            return Input.GetTouch(id);
        #endif
    }

    public static int TouchCount()
    {
        #if UNITY_EDITOR
            if (Input.GetKey(KeyCode.Mouse0))
                return 1;
            else
                return 0;
        #else   
            return Input.touchCount;
        #endif
    }
}