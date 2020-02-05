using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class Debugger : ScriptableObject
{
   public void OnDebug (string message)
   {
      Debug.Log(message);
   }
}

