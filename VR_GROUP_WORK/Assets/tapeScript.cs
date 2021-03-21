using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class tapeScript : MonoBehaviour
{
    // Audio Sources
    public AudioSource audio1;
    public AudioSource audio2;
    public AudioSource audio3;
    public AudioSource audio4;
    public AudioSource audio5;
    public AudioSource audio6;
    public AudioSource audio7;

    // First Person Camera.
    public Camera fpsCam;

    // Update is called once per frame
    void Update()
    {
        // If mouse down.
        if (Input.GetMouseButtonDown(0))
        {
            // Raycast object
            RaycastHit hit;

            // If raycast has hit something.
            if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit))
            {
                // If raycast hit audio tape1...
                if (hit.transform.name == "tape1")
                {
                    // Play audio 1
                    audio1.Play();
                }

                // If raycast hit audio tape2...
                else if (hit.transform.name == "tape2")
                {
                    // Play audio 2
                    audio2.Play();
                }

                // If raycast hit audio tape3...
                else if (hit.transform.name == "tape3")
                {
                    // Play Audio 3
                    audio3.Play();
                }

                // If raycast hit audio tape4...
                else if (hit.transform.name == "tape4")
                {
                    // Play Audio 4
                    audio4.Play();
                }

                // If raycast hit audio tape5...
                else if (hit.transform.name == "tape5")
                {
                    // Play Audio 5
                    audio5.Play();
                }

                // If raycast hit audio tape6...
                else if (hit.transform.name == "tape6")
                {
                    // Play Audio 6
                    audio6.Play();
                }

                // If raycast hit audio tape5...
                else if (hit.transform.name == "tape7")
                {
                    // Play Audio 7
                    audio7.Play();
                }
            }
        }
    }
}
