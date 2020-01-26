using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageController : MonoBehaviour
{
   private Image imageComponent;

   private void Start()
   {
      imageComponent.GetComponent<Image>();
     
   }

   public void UpdateImageComponent(float amount)
   {
      imageComponent.fillAmount += amount;
   }

   public void UpdateImageComponent(FloatdataValue dataobj)
   {
      imageComponent.fillAmount = dataobj.Value;
   }
}
