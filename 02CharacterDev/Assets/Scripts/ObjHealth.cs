using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjHealth : MonoBehaviour

{
//change to FloatData
    public float maxHealth = 20f;
//change to private in production
    public float currentHealth;
    public List<GameObject> LootTable;

    private GameObject droppedLoot; //this is the loot that is dropped in the dropLoot() function

    public Slider healthBar;

    void Update()
    {
        onZeroHealth();
        
    }

    public void ChangeHealth(float delta)
    {
        currentHealth += delta;
        /*if (healthBar != null)
        {
            healthBar.GetComponent<HealthBar>().SetHealth(currentHealth);
        }*/
        //healthBar.GetComponent<HealthBar>().SetHealth(currentHealth);
    }

    private void onZeroHealth ()
    {


        if (currentHealth == 0)
        {

            (gameObject.GetComponent(typeof(Collider)) as Collider).isTrigger = false;

            Destroy(gameObject);
            dropLoot();
        }

    }

    private void dropLoot()
    {

        if (LootTable.Count > 0)
        {

            int rand = Random.Range(0, LootTable.Count);
            droppedLoot = LootTable[rand];
            Instantiate(droppedLoot, gameObject.GetComponent<Transform>().position, gameObject.GetComponent<Transform>().rotation);
        }

    }

}