using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]

public class TextB2: MonoBehaviour
{
     /// <summary> experiment

     public UnityEvent awakeEvent;
     private Text textObj;


     private void Awake()
     {
          textObj = GetComponent<Text>();
          awakeEvent.Invoke();  //update itself upon awake 
     }

     public void UpdateText(StringListData stringListDataObj)
     {
          textObj.text = stringListDataObj.ReturnCurrentLine();
     }
     public void UpdateText(IntData intDataObj)
     {
          //textObj.text = intDataObj.value / ToString();
     }
}