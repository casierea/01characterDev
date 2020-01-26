using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectRandomObj : MonoBehaviour
{
    public List<GameObject> objs;
    public GameObject SelectedObject;

    public void Select()
    {
        int rand = Random.Range(0, objs.Count);
        SelectedObject = objs[rand];
    }

   
}