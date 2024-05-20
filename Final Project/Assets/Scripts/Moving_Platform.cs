using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Platform : MonoBehaviour
{
    //Variables for moving platform
    public Vector3 StartPosition = new Vector3 (0, 0, 0);
    public Vector3 EndPosition = new Vector3 (0, 0, 0);
    public int speed = 3;
    public bool foward = true;

    // Update is called once per frame
    void Update()
    {
        //When game object reaches EndPosition set foward to false and vice versa when it reaches the StartPosition
        if (gameObject.transform.position.x == EndPosition.x)
        {
            foward = false;
        }    
        if (gameObject.transform.position.x == StartPosition.x)
        {
            foward = true;
        }
        //Movement when foward is true
        if (foward == true)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + (Time.deltaTime + speed), gameObject.transform.position.y,gameObject.transform.position.z);
        }
        if (foward == false)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x - (Time.deltaTime - speed), gameObject.transform.position.y, gameObject.transform.position.z);
        }

    }
}
