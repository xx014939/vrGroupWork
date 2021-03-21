using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour

{

    public GameObject light1;
    private Light light1_comp;
    public GameObject light2;
    private Light light2_comp;
    public GameObject light3;
    private Light light3_comp;
    public GameObject light4;
    private Light light4_comp;

    private bool lightSwitch;



    void Start()
    {
        light1_comp = light1.GetComponent<Light>();
        light2_comp = light2.GetComponent<Light>();
        light3_comp = light3.GetComponent<Light>();
        light4_comp = light4.GetComponent<Light>();

        lightSwitch = true;
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered");
    }


    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E - Pressed");

            if (lightSwitch == true)
            {
                Debug.Log("Switching off");
                switchOff();
            }
            
            if (lightSwitch == false)
            {
                Debug.Log("Switching on");
                switchOn();
                
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Left lol");


    }

    void switchOff()
    {
        light1_comp.enabled = false;
        light2_comp.enabled = false;
        light3_comp.enabled = false;
        light4_comp.enabled = false;

        lightSwitch = false;
    }

    void switchOn()
    {
        light1_comp.enabled = true;
        light2_comp.enabled = true;
        light3_comp.enabled = true;
        light4_comp.enabled = true;

        lightSwitch = true;
    }
}