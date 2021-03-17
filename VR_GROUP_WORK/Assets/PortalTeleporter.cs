﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTeleporter : MonoBehaviour
{

    public Transform player;
    public Transform receiver;

    private bool playerIsOverlapping = false;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (playerIsOverlapping)
        {            
            Vector3 portalToPlayer = player.position - transform.position;

            float dotProduct = Vector3.Dot(transform.up, portalToPlayer); //dot product

            //player has moved across portal
            if (dotProduct < 0f)
            {
                //teleport
                float rotationDiff = -Quaternion.Angle(transform.rotation, receiver.rotation);
                rotationDiff += 180;
                player.Rotate(Vector3.up, rotationDiff);

                Vector3 positionOffset = Quaternion.Euler(0f, rotationDiff, 0f) * portalToPlayer; //x  y z
                player.position = receiver.position + positionOffset;

                playerIsOverlapping = false;
                

            }
        }   
    }

    void OnTriggerEnter (Collider other)
    {
        Debug.Log("Enter --");
        if (other.tag == "Player")
        {
            playerIsOverlapping = true;
        }
    }

    void OnTriggerExit (Collider other)
    {
        if (other.tag == "Player")
        {
            playerIsOverlapping = false;
        }
    }
}
