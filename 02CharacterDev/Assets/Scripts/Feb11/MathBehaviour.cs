using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathBehaviour : MonoBehaviour
//cant have a damager here. bc it implies ONE damager.
//Need mutliple damagers
//dont make this a health script. It is add and subtract value script.
{
    public FloatData healthData;

    
    public FloatData[] dataList;  //array so can cnahge size
    //public FloatData damagerData;
    private NameId otherNameID;
    private void OnTriggerEnter(Collider other)
    {
        otherNameID = other.GetComponent<NameId>();
    }

    public void ChangeHealth(FloatData incommingDamager)
    {
        foreach (var data in dataList)
        {
            //var newID = otherNameID as FloatData;
            
            if (data == incommingDamager)
            {
                healthData.UpdateValue(data.value); //he has Value
            }
        }
        
        //healthData.SetValue(damagerData); //Do I have a setvalue script?
    }
    //public float Updatevalue = 1f;

    // public void AddValue (float f)
    // {
    // value += f;
    // }

    // public void ChangeValue(float f)
    //{
    //    value = f;
    // }
}
