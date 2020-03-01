using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.UIElements;
using UnityEngine;

public class ValueManager : MonoBehaviour
{
    public FloatData Total;

    public void ChangeSparkleTotal(float delta)
    {
        Total.value += delta;
    }
    
    
}
