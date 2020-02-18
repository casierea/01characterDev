using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Instancing/Instance Object")]
public class InstanceObject : ScriptableObject
{
    public GameObject prefab;
    
    public void CreateInstance(GameObject instance)
    {
        //instantiate(instance);
    }
    
    public void CreateInstanceAtLocation(Vector3 location)
    {
        //Instantiate(prefab, location.value, Quaternion.identity);
    }
}
