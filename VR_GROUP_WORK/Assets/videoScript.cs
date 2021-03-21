using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class videoScript : MonoBehaviour
{
    public Camera fpsCam;
    public GameObject button;
    public VideoPlayer video;
    bool play = false;


    // Start is called before the first frame update
    void Start()
    {
        video.Stop();
    }


    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Debug.Log("PLAY VIDEO");

        }
           
    }

    void OnMouseExit()
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
        Debug.Log("Mouse is no longer on GameObject.");
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit))
            {
                if (hit.transform.name == "PlayVideo")
                {
                    if (play == false)
                    {
                        video.Play();
                        play = true;
                    }

                    else
                    {
                        video.Pause();
                        play = false;
                    }
                }
            }
        }

        else if (Input.GetMouseButtonUp(0))
        {

        }

    }
}
