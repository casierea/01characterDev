using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Single Variable/BoolData")] //menu name, folder name, object name
public class BooldataObj : ScriptableObject
{
   //value should be lower case
   public bool value;

   public void Setvalue(bool valueChange)
   {
      value = valueChange;
   }
}
