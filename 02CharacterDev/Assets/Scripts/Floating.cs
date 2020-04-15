using UnityEngine;
 using System.Collections;
  
 // Makes objects float up & down while gently spinning.
 public class Floating : MonoBehaviour {
     // User Inputs
     public float derpPerSecond = 15.0f;
     public float GoON = 0.5f;
     public float speedy = 1f;
  
     // Position Storage Variables
     Vector3 posOffset = new Vector3 ();
     Vector3 tempPos = new Vector3 ();
  
     // Use this for initialization
     void Start () {
        
         posOffset = transform.position;
     }
      
 
     void Update () {
         // y axis rotate
         //transform.Rotate(new Vector3(0f, Time.deltaTime * derpPerSecond, 0f), Space.World);
  
         //Float up and then down
         tempPos = posOffset;
         tempPos.y += Mathf.Sin (Time.fixedTime * Mathf.PI * speedy) * speedy;
  //can change for z and x to make platforms move in different directions
         transform.position = tempPos;
     }
 }