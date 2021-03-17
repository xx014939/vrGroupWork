using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTextureSetup : MonoBehaviour
{

    // public Camera cameraA;
    public Camera swCamera;
    public Material swCameraMat;

    public Camera mhCamera;
    public Material mhCameraMat;
    
    // Start is called before the first frame update
    void Start()
    {

        if (mhCamera.targetTexture != null)
        {
            mhCamera.targetTexture.Release();
        }
        mhCamera.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        mhCameraMat.mainTexture = mhCamera.targetTexture;


        if (swCamera.targetTexture != null)
        {
            swCamera.targetTexture.Release();
        }
        swCamera.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        swCameraMat.mainTexture = swCamera.targetTexture;
    }


}
