using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoolAnim : MonoBehaviour
{
    //online Unity Forum Help
    
    
    public int cubesToTrigger = 3; // the number of objects (cube) that have to touch the trigger to play the animation
    public Animator anim; //The animator component that holds the animation I want to play
    private int COF = 0; // the variable that counts the objects (cubes) that touch the trigger
         
 
    void Start () {
        anim.enabled = true;
        anim.SetBool("levelFinished", false); //when you have animations in your game, there's a tab next to "Scene", "Game" and "Asset Store" named "Animator". There
    }
 
    void OnTriggerEnter (Collider Cube) {
        if (Cube.gameObject.tag == "cube") {
            COF ++; // each time an object with the cube tag touch the trigger, it adds 1 to COF
        }
    }
     
    void AnimStart() {
        anim.SetBool("levelFinished", true); // a function that sets the value of the boolean you created in you animator window to true when it's called
    }
  
 
    void Update () {
        if (COF == cubesToTrigger) {
            Invoke ("AnimStart", 1.5f);  // call the function with a delay of 1 second and a half
        }
    }
}
