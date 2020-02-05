using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBooldata : MonoBehaviour
{
   public BooldataObj booldataObj;

   private void Update()
   {
      if (booldataObj.value)
      {
         print("true"); //do work like maybe fire, power up. if character runs into the wall, stop. (On character controller)
      }
      else
      {
         //do this instead
      }
   }
}
