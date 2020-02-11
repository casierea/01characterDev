using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Health : ScriptableObject
//cant have a damager here. bc it implies ONE damager.
//Need mutliple damagers
//dont make this a health script. It is add and subtract value script.
{
    public FloatData healthData;

    
    public FloatData[] damagerList;  //array so can cnahge size
    //public FloatData damagerData;

    public void ChangeHealth(FloatData incommingDamager)
    {
        foreach (var damager in damagerList)
        {
            if (damager == incommingDamager)
            {
                healthData.UpdateValue(damager.value); //he has Value
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
