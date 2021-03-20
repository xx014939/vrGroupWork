using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControls : MonoBehaviour
{
    public Transform playerBody;

    public float xRotation = 0f;

    public float yRotation = 0f;

    Vector2 rotation = new Vector2(0, 0);

    public float mouseSensitivity = 2f;

    void Awake()
    {
        Application.targetFrameRate = 30;
    }

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        rotation.y += Input.GetAxis("Mouse X");
        rotation.x += -Input.GetAxis("Mouse Y");

        if (rotation.x > 40f)
        {
            rotation.x = 40f;
        }

        else if (rotation.x < -40f)
        {
            rotation.x = -40f;
        }

        transform.eulerAngles = (Vector2)rotation * mouseSensitivity;
    }

    /*
    public float speed = 20f;

    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    float xRotation = 0f;
    float yRotation = 0f;

    public float mouseSpeed = 100f;
    public Transform playerBody;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = (Input.mousePosition.x / Screen.width) - 0.5f;
        float mouseY = (Input.mousePosition.y / Screen.height) - 0.5f;
        transform.localRotation = Quaternion.Euler(new Vector4(-1f * (mouseY * 180f), mouseX * 360f, transform.localRotation.z));
    }
    */
}