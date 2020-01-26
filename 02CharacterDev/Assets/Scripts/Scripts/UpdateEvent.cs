using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UpdateEvent : MonoBehaviour
{
   public UnityEvent OnUpdateEvent;

   void Update()
   {
      OnUpdateEvent.Invoke();
   }
}
