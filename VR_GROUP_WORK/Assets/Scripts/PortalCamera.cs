using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCamera : MonoBehaviour
{
    public Transform playerCamera; // player camera
    public Transform portalCloseToCamera; // Portal it belongs to
    public Transform portalCloseToPlayer; //pos of other portal


    // Update is called once per frame
    void Update()
    {
        Vector3 playerOffsetFromPortal = playerCamera.position - portalCloseToPlayer.position;
        transform.position = portalCloseToCamera.position + playerOffsetFromPortal; //this camers pos + offset

        float angularDifferenceBetweenPortalRotations = Quaternion.Angle(portalCloseToCamera.rotation, portalCloseToPlayer.rotation);

        Quaternion portalRotationalDifference = Quaternion.AngleAxis(angularDifferenceBetweenPortalRotations, Vector3.up);
        Vector3 newCameraDirection = portalRotationalDifference * playerCamera.forward;
        transform.rotation = Quaternion.LookRotation(newCameraDirection, Vector3.up);
    }
}
