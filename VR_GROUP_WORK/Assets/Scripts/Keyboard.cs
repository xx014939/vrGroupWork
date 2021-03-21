using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyboard : MonoBehaviour
{
    public float speed = 10f;

    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    float xRotation = 0f;
    float yRotation = 0f;

    public float mouseSpeed = 100f;
    public Transform playerBody;
    public Camera Camera;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      

        if (Input.GetKey(KeyCode.A))
        {
            
            playerBody.position = transform.position + -Camera.transform.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
           
            playerBody.position = transform.position + Camera.transform.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W))
        {;
            playerBody.position = transform.position + Camera.transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            playerBody.position = transform.position + -Camera.transform.forward * speed * Time.deltaTime;
        }

        playerBody.position = new Vector3(playerBody.position.x, 1.5f, playerBody.position.z);


    }
}
