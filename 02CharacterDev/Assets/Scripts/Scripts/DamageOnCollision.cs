using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnCollision : MonoBehaviour
{
    public FloatdataValue Value;

    private void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.GetComponent<RedoObjHealth>()) //need a obj health script of some sort
        //{
        //    other.GetComponent<RedoObjHealth>().DamageHealth(DamageOnCollision.Value);
        //}

       // if (other.gameObject.GetComponent<MultiObjHealth>())
       // {
       //     other.GetComponent<MultiObjHealth>().DamageHealth(DamageOnCollision.Value);
       // }
    }
}
