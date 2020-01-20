using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class CharacterControl : MonoBehaviour
{
    private Vector3 position;
    private CharacterController controller;

    
    public float Height = 10f;
    public float Radius = 2f;
    public float Offset = .3f;
    public GameAction action;
    public float Velocity = 4f;
    public Material matieral;
        
    private void Start()
    {
        controller.GetComponent<CharacterController>();
    }

    private void SetHeight()
    {
        controller.height = Height;
    }

    private void SetRadius()
    {
        controller.radius = Radius;
    }

    private void SetOffset()
    {
        controller.stepOffset = Offset;
    }

   
}
