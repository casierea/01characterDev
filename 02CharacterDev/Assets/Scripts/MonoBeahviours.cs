using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class MonoBeahviours : MonoBehaviour
{
   [FormerlySerializedAs(oldName: "Event")]
   public UnityEvent awakeEvent;
   
   [FormerlySerializedAs(oldName: "StartEvent")]
   public UnityEvent startEvent;
   
   [FormerlySerializedAs(oldName: "QuitEvent")]
   public UnityEvent quitEvent;


   private void Awake()
   {
      awakeEvent.Invoke();
   }
   
   private void Start()
   {
      
   }
   
   private void OnApplicationQuit()
   {
      quitEvent.Invoke();
      
   }
}

