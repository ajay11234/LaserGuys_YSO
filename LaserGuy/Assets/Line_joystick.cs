using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line_joystick : MonoBehaviour
{
    // Start is called before the first frame update
    public Joystick joystick;
    public float rotateVertical;
    public float rotateHorizontal;

    
    void FixedUpdate()
    {
        rotateVertical = joystick.Vertical * 1f;
        rotateHorizontal = joystick.Horizontal * -1f;

         transform.Rotate(0,rotateHorizontal,0);
    }
}
