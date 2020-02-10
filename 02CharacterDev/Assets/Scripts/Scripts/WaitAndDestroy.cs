using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitAndDestroy : MonoBehaviour
{
   public float SecondsUntilDestroyed;

   IEnumerator Start()
   {
      yield return new WaitForSeconds(SecondsUntilDestroyed);
      Destroy(gameObject);
   }
   
   private void OnCollisionEnter(Collision other)
   {
      Destroy(gameObject);
   }
}
