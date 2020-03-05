using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MatchID : MonoBehaviour
{
    public List<NameId> nameIDList;

    private void OnTriggerEnter(Collider other)
    {
        var doworkobj = other.GetComponent<DoWork>();
        var otherNameID = doworkobj.nameIdObj;
        
        foreach (var nameId in nameIDList)
        {
           
            if (nameId == otherNameID)
            {
               
            }
        }
    }
    
    
    

    //public NameId nameIDObj;

    // private void OnTriggerEnter(Collider other)
    //{
    //  var nameIdObj = other.GetComponent<MatchID>().nameIDObj;
    //  if (nameIdObj == null) return;
    //  var otherNameId = nameIdObj;
    //   if (nameIDObj == otherNameId)
    //  {
    //do work
    //  }
    //}
}
