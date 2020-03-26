﻿using System.Collections.Generic;
using Basics;
using UnityEngine;
using UnityEngine.Serialization;

//Made By Anthony Romrell
public class AddPointsList : MonoBehaviour
{

    private List<Vector3Data> points;
    public List<Transform> pointObjects;
    public GameAction onSendAction;

    private void Awake()
    {
        points = new List<Vector3Data>();
        foreach (var obj in pointObjects)
        {
            UpdateInfo(obj);
        }
        SendAction();
    }

    public void UpdateInfo(Transform t)
    {
        Vector3Data temp = ScriptableObject.CreateInstance<Vector3Data>();
        temp.Value = t.position;
        points.Add(temp);
    }

    public void SendAction()
    {
        onSendAction.Raise(points);
        print(points);
    }
}