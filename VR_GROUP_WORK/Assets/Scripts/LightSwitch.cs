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

    private bool lightSwitch = true; 



    void Start()
    {
        light1_comp = light1.GetComponent<Light>();
        light2_comp = light2.GetComponent<Light>();
        light3_comp = light3.GetComponent<Light>();
        light4_comp = light4.GetComponent<Light>();
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("Stayed");

        if (other.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E - Pressed");

            if (lightSwitch == true)
            {
                Debug.Log("Switching off");
                light1_comp.enabled = false;
                light2_comp.enabled = false;
                light3_comp.enabled = false;
                light4_comp.enabled = false;
                lightSwitch = false;
            }
            else
            {
                Debug.Log("Switching on");
                light1_comp.enabled = true;
                light2_comp.enabled = true;
                light3_comp.enabled = true;
                light4_comp.enabled = true;
                lightSwitch = true;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Left lol");


    }
}