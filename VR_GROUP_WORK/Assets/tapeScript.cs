using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class tapeScript : MonoBehaviour
{
    public AudioSource audio1;
    public AudioSource audio2;
    public AudioSource audio3;
    public AudioSource audio4;
    public AudioSource audio5;
    public AudioSource audio6;
    public AudioSource audio7;
    public Camera fpsCam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit))
            {
                if (hit.transform.name == "tape1")
                {
                    audio1.Play();
                }

                else if (hit.transform.name == "tape2")
                {
                    audio2.Play();
                }

                else if(hit.transform.name == "tape3")
                {
                    audio3.Play();
                }

                else if(hit.transform.name == "tape4")
                {
                    audio4.Play();
                }

                else if (hit.transform.name == "tape5")
                {
                    audio5.Play();
                }

                else if (hit.transform.name == "tape6")
                {
                    audio6.Play();
                }

                else if (hit.transform.name == "tape7")
                {
                    audio7.Play();
                }
            }
        }
    }
}
