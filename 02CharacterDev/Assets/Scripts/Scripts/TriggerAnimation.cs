using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    public Animator Anim;
    
    void Start()
    {
        Anim = gameObject.GetComponent<Animator>();
        
    }

   
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Anim.ResetTrigger("Crouch");
            Debug.Log("Crouch");
            Anim.SetTrigger("Jump");
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Anim.ResetTrigger("Jump");
            Debug.Log("jump");
            Anim.SetTrigger("Crouch");
        }
    }
   
}
