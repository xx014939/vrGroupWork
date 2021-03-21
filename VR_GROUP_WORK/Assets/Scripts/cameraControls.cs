using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControls : MonoBehaviour
{
    // Player body.
    public Transform playerBody;

    // rotation vector.
    Vector2 rotation = new Vector2(0, 0);

    // Mouse sensitivity.
    public float mouseSensitivity = 2f;

    void Awake()
    {
        Application.targetFrameRate = 30;
    }

    // Start is called before the first frame update
    void Start()
    {
        // Locks the cursor to the centre of the screen.
        Cursor.lockState = CursorLockMode.Locked;

        // Hides curser from view.
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Y axis rotation.
        rotation.y += Input.GetAxis("Mouse X");

        // X axis rotation.
        rotation.x += -Input.GetAxis("Mouse Y");

        // Limit how far player can look up.
        if (rotation.x > 40f)
        {
            rotation.x = 40f;
        }

        // Limit how far player can look down.
        else if (rotation.x < -40f)
        {
            rotation.x = -40f;
        }

        transform.eulerAngles = (Vector2)rotation * mouseSensitivity;
    }
}