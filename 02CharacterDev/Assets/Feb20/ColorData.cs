﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Single Variables/ColorData")]
public class ColorData : NameID
{
    
    
    //not being identified by name, being identifed by object
    //if this is obj is this obj then do this job
    
    public Color value = Color.blue;

    public void ChangeSpriteRendererColor(SpriteRenderer spriteRendererObj)
    {
        spriteRendererObj.color = value;
    }
    
    public void ChangeSpriteRendererColor(SpriteRendererController spriteRendererController)
    {
        spriteRendererController.spriteRenderObj.color = value;
    }
}