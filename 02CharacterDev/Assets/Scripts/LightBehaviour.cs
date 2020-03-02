using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.UIElements;
using UnityEngine;

public class lightBehavior : MonoBehaviour
{
    public FloatData playerSparkleTotal;
    public int lossRate = 5;
    private Boolean lightStatus = false;

    private void Update()
    {
        this.GetComponent<Light>().enabled = lightStatus;
        this.GetComponent<Light>().intensity = playerSparkleTotal.value;
        this.GetComponent<Light>().range = playerSparkleTotal.value / 10;
        if (Input.GetKeyDown(KeyCode.E))
        {
            lightSwitch();
        }

        if (lightStatus == true)
        {
            playerSparkleTotal.value -= lossRate * Time.deltaTime;
        }
    }
    private void lightSwitch()
    {
        if (playerSparkleTotal.value > 0)
        {
            lightStatus = !lightStatus;
            this.GetComponent<Light>().enabled = lightStatus;    
        }
        else
        {
            lightStatus = false;
        }
    }


}