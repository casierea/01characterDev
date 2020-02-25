using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class SpriteRendererController : ScriptableObject
{
   [HideInInspector]
   public SpriteRenderer spriteRenderObj;

   public void StoreSpriteRendere(SpriteRenderer spriteRenderer)
   {
      spriteRenderObj = spriteRenderer;
   }
}
