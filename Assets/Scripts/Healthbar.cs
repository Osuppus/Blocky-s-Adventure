using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    //GLOBAL VARIABLES
    public Slider slider; //declare & set slider UI variable in the inspector

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //NOTE: these voids are public so we can call them from other scripts
    //Change the Health Slider
    public void SetHealth(int health) //declare a void & feed it a variable (in this case an integer) 
    {
        slider.value = health; //change the value parameter of the slider to equal the value of health
    }
    //set the max value of the health bar
    public void SetMaxHealth(int health) //declare a void & feed it a variable (in this case an integer) 
    {
        slider.maxValue = health; //set health to the max value of our slider component
        slider.value = health; //set the value of our slider comonent to health
    }
}
