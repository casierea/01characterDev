using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class CharacterMove : MonoBehaviour
{
    private CharacterController Controller;

    private float Gravity = 9.81f;
    public float MoveSpeed = 3.14f;
    private Vector3 Rot;

    public Vector3 position;
    
    public float Jump = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        Controller = GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Controller.isGrounded)
        {
            position.Set(MoveSpeed * Input.GetAxis("Horizontal"), 0, MoveSpeed * Input.GetAxis("Vertical"));
            position = transform.TransformDirection(position);
        }

        position.y -= Gravity * Time.deltaTime;
        Controller.Move(position * Time.deltaTime);
    }
}
