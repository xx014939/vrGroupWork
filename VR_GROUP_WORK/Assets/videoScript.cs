using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class videoScript : MonoBehaviour
{
    public Camera fpsCam;
    public GameObject button;
    public VideoPlayer video;
    
    // Start is called before the first frame update
    void Start()
    {
        video.Stop();      
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
                    Debug.Log(hit.transform.name);
                    video.Play();   
                }
            }
        }

        else if (Input.GetMouseButtonUp(0))
        {

        }
    }
}
