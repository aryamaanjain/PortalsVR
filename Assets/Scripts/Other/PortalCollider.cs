using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCollider : MonoBehaviour
{
    public Transform portalBlue;
    public Transform portalRed;
    public Gun gunScript;
    public Collider colliderFloor;
    public Collider colliderRoof;
    public Collider colliderWall1;
    public Collider colliderWall2;
    public Collider colliderWall3;
    public Collider colliderWall4;
    bool colliderOff = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 redCenter = portalRed.position + portalRed.transform.up * 1.5f;
        float distanceRed = Vector3.Distance(redCenter, transform.position);

        Vector3 blueCenter = portalBlue.position + portalBlue.transform.up * 1.5f;
        float distanceBlue = Vector3.Distance(blueCenter, transform.position);

        if (distanceRed < 1.5f || distanceBlue < 1.5f)
        {
            colliderOff = true;
            string currentSurfaceRed = gunScript.currentSurfaceRed;
            string currentSurfaceBlue = gunScript.currentSurfaceBlue;

            if (currentSurfaceRed == "Floor" || currentSurfaceBlue == "Floor")
            {
                colliderFloor.enabled = false;
            }
            if (currentSurfaceRed == "Roof" || currentSurfaceBlue == "Roof")
            {
                colliderRoof.enabled = false;
            }
            if (currentSurfaceRed == "Wall 1" || currentSurfaceBlue == "Wall 1")
            {
                colliderWall1.enabled = false;
            }
            if (currentSurfaceRed == "Wall 2" || currentSurfaceBlue == "Wall 2")
            {
                colliderWall2.enabled = false;
            }
            if (currentSurfaceRed == "Wall 3" || currentSurfaceBlue == "Wall 3")
            {
                colliderWall3.enabled = false;
            }
            if (currentSurfaceRed == "Wall 4" || currentSurfaceBlue == "Wall 4")
            {
                colliderWall4.enabled = false;
            }
        }

        if (colliderOff && distanceRed > 1.5 && distanceBlue > 1.5)
        {
            colliderFloor.enabled = true;
            colliderRoof.enabled = true;
            colliderWall1.enabled = true;
            colliderWall2.enabled = true;
            colliderWall3.enabled = true;
            colliderWall4.enabled = true;
        }
    }
}
