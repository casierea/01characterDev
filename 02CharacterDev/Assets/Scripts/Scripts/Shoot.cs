using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
   public Transform WeaponPosition;
   public GameObject EnemyShoot;
   public float ShootSpeed;
   public FloatData BulletSpeed;
   
   private bool FacingRight;
   private bool FacingLeft;
   private bool ReadyToFire;

   //private void Update()
   //{
      //FacingRight = gameObject.flipX;
   //}

   private void OnTriggerStay(Collider other)
   {
      if (other.tag == "Player & readyToFire")
      {
         Invoke("BeginShoot", 0.5f);
         Debug.Log("After begin shoot" + ReadyToFire);

         StartCoroutine(ShootDelay(1.0f));
         Debug.Log("After begine delay" + ReadyToFire);
      }
   }

   private IEnumerator ShootDelay(float waitTime)
   {
      ReadyToFire = false;
      yield return new WaitForSeconds(waitTime);
      ReadyToFire = true;
      Debug.Log("After ready set true");
   }

   void BeginShoot()
   {
      if (FacingRight == false)
      {
         ShootSpeed = -BulletSpeed.value;
      }
      else
      {
         ShootSpeed = BulletSpeed.value;
      }
      GameObject Clone;
      Clone = Instantiate(EnemyShoot, WeaponPosition.position, transform.rotation);
      Clone.GetComponent<Rigidbody>().AddForce(ShootSpeed,0,0);
   }
}
