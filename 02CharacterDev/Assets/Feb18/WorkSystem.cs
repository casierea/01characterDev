using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public abstract class WorkSystem : ScriptableObject
{
    public NameID NameIdObj { get; set; }
    public UnityEvent workEvent;
    public abstract void Work();
}