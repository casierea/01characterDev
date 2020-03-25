using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Destroyer : ScriptableObject
{
    public void DestroyThis()
    {
        Destroy(this);
    }

    public void DestroyObj(Object obj)
    {
        Destroy(obj);
    }

}
