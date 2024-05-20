using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class Playerbehavior : MonoBehaviour
{
    //Variables for player movement
    public float MoveSpeed = 10f;
    public float RotateSpeed = 75f;
    public float JumpVelocity = 5f;
    public float DistanceToGround = 0.1f;

    private Vector3 jump;
    private bool _isGrounded;
    private bool _isSprinting;
    private float _vInput;
    private float _hInput;
    private Rigidbody _rb; 

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        jump = new Vector3(0f,5f,0f); 
    }
    //Makes sure the player is grounded before another jump can occur
    void OnCollisionEnter()
    {
        _isGrounded = true;
    }
    // Update is called once per frame
    void Update()
    {
        //Inputs for Foward and Backwards movement
        _vInput = Input.GetAxis("Vertical") * MoveSpeed;
        _hInput = Input.GetAxis("Horizontal") * RotateSpeed;
        //Jumping
        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            _rb.AddForce(jump *JumpVelocity,ForceMode.Impulse);
            _isGrounded = false;
        }
    }
    void FixedUpdate()
    {
        //Player movement and rotation
        Vector3 rotation = Vector3.up * _hInput;
        Quaternion angleRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);
        _rb.MovePosition(this.transform.position + this.transform.forward * _vInput * Time.fixedDeltaTime);
        _rb.MoveRotation(_rb.rotation * angleRot);
    }
}
