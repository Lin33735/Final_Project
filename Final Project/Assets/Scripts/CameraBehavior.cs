using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    public Vector3 CamOffset = new Vector3 (0f, 3f, -5f);
    private Transform _target;

    // Start is called before the first frame update
    void Start()
    {
        //Attaches Player transform to Camera
        _target = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Makes the Camera follow the Player
        this.transform.position = _target.TransformPoint(CamOffset);
        this.transform.LookAt(_target);
    }
}
