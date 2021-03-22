using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{

    public GameObject light1; //Declaring the light variables
    private Light light1_comp;
    public GameObject light2;
    private Light light2_comp;
    public GameObject light3;
    private Light light3_comp;
    public GameObject light4;
    private Light light4_comp;
    public GameObject LightInstructionsOff;
    public GameObject LightInstructionsOn;
    private bool lightSwitch = true;

    void Start()
    {
        light1_comp = light1.GetComponent<Light>(); //initializing the lights
        light2_comp = light2.GetComponent<Light>();
        light3_comp = light3.GetComponent<Light>();
        light4_comp = light4.GetComponent<Light>();
        LightInstructionsOff.SetActive(false);
        LightInstructionsOn.SetActive(false);

    }

    void OnTriggerStay(Collider other)
    {


        if (lightSwitch)
        {

            LightInstructionsOn.SetActive(false);
            LightInstructionsOff.SetActive(true);
            if (Input.GetMouseButtonDown(1)) //if the player presses right click
            {

                light1_comp.enabled = false; //turn lights on 
                light2_comp.enabled = false;
                light3_comp.enabled = false;
                light4_comp.enabled = false;
                lightSwitch = false;

            }
        }
        if (!lightSwitch)
        {
            LightInstructionsOff.SetActive(false);
            LightInstructionsOn.SetActive(true);
            if (Input.GetMouseButtonDown(0)) //if the player presses left click
            {

                light1_comp.enabled = true; //turn lights on 
                light2_comp.enabled = true;
                light3_comp.enabled = true;
                light4_comp.enabled = true;
                lightSwitch = true;


            }
        }

    }

    void OnTriggerExit(Collider other)
    {

        LightInstructionsOff.SetActive(false); //remove panel 
        LightInstructionsOn.SetActive(false);

    }
}