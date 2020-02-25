using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteRendererBehaviour : MonoBehaviour
{
   
    private SpriteRenderer spriteRendererObj;
    public ColorData colorDataObj;
    public UnityEvent startEvent;
    void Start()
    {
        spriteRendererObj = GetComponent<SpriteRenderer>();
        startEvent.Invoke();
    //ChangeSpriteColor(); this will work. But have to write a new script So we create a unity evemt.
    }

    public void ChangeSpriteColor(ColorData colorDataObj)
    {
        //doesnt have to call function, but can. is this the right place to type this?
        spriteRendererObj.color = colorDataObj.value;
    }

   
}
