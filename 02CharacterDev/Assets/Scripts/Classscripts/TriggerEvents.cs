using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvents : MonoBehaviour
{

   public UnityEvent TriggerEnterEvent, TriggerExitEvent;

   private void OnTriggerEnter(Collider other)
   {
      TriggerEnterEvent.Invoke();
      Debug.Log("again");
   }

   private void OnTriggerExit(Collider other)
   {
      TriggerExitEvent.Invoke();
      Debug.Log("Exit");
   }
}
