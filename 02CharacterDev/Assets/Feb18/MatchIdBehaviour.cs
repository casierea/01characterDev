using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchIdBehaviour : MonoBehaviour
{
   //2nd match id behaviour made in class
   public WorkSystemManager workSystemManagerObj;

   private NameID otherIdObj;

   private void OnTriggerEnter(Collider other)
   {
      otherIdObj = other.GetComponent<IdBehaviour>().nameIdObj;
      CheckId();
      
   }

   private void CheckId()
   {
      foreach (var obj in workSystemManagerObj.workIdList)
      {
         if (otherIdObj == obj.nameIdObj)
         {
            obj.worksystemObj.Work();
         }
      }
   }
}
