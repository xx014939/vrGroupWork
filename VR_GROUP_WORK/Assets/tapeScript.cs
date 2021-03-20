using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class tapeScript : MonoBehaviour
{
    public AudioSource audio;
    public AudioSource audio1;
    public AudioSource audio2;
    public AudioSource audio3;
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
                    audio.Play();
                }

                if (hit.transform.name == "tape2")
                {
                    audio1.Play();
                }

                if (hit.transform.name == "tape3")
                {
                    audio2.Play();
                }

                if (hit.transform.name == "tape4")
                {
                    audio3.Play();
                }
            }
        }
    }
}
