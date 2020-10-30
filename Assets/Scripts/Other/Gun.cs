using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float range = 100f;
    public Camera fpsCam;
    
    public float portalOffset = 0.1f;
    public Transform portalRed;
    public Transform portalBlue;
    int currentPortal = 0;  // 0 Red, 1 Blue

    public string currentSurfaceRed;
    public string currentSurfaceBlue;

    public ParticleSystem muzzleFlash;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        muzzleFlash.Play();

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            // Debug.Log(hit.transform.name);

            if (hit.transform.name == "Wall 1")
            {
                // positions
                float px = hit.point.x;
                float py = hit.point.y;
                float pz = hit.point.z - portalOffset;

                if (currentPortal == 0)
                {
                    portalRed.transform.position = new Vector3(px, py, pz);
                    portalRed.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                    currentSurfaceRed = "Wall 1";
                    currentPortal = 1;
                }
                else
                {
                    portalBlue.transform.position = new Vector3(px, py, pz);
                    portalBlue.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                    portalBlue.transform.Rotate(portalBlue.transform.up, 180);
                    currentSurfaceBlue = "Wall 1";
                    currentPortal = 0;
                }
            }

            else if (hit.transform.name == "Wall 2")
            {
                // positions
                float px = hit.point.x;
                float py = hit.point.y;
                float pz = hit.point.z + portalOffset;

                if (currentPortal == 0)
                {
                    portalRed.transform.position = new Vector3(px, py, pz);
                    portalRed.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                    portalRed.transform.Rotate(portalRed.transform.up, 180);
                    currentSurfaceRed = "Wall 2";
                    currentPortal = 1;
                }
                else
                {
                    portalBlue.transform.position = new Vector3(px, py, pz);
                    portalBlue.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                    currentSurfaceBlue = "Wall 2";
                    currentPortal = 0;
                }
            }

            else if (hit.transform.name == "Wall 3")
            {
                // positions
                float px = hit.point.x - portalOffset;
                float py = hit.point.y;
                float pz = hit.point.z;

                if (currentPortal == 0)
                {
                    portalRed.transform.position = new Vector3(px, py, pz);
                    portalRed.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                    portalRed.transform.Rotate(portalRed.transform.up, 90);
                    currentSurfaceRed = "Wall 3";
                    currentPortal = 1;
                }
                else
                {
                    portalBlue.transform.position = new Vector3(px, py, pz);
                    portalBlue.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                    portalBlue.transform.Rotate(portalBlue.transform.up, -90);
                    currentSurfaceBlue = "Wall 3";
                    currentPortal = 0;
                }
            }

            else if (hit.transform.name == "Wall 4")
            {
                // positions
                float px = hit.point.x + portalOffset;
                float py = hit.point.y;
                float pz = hit.point.z;

                if (currentPortal == 0)
                {
                    portalRed.transform.position = new Vector3(px, py, pz);
                    portalRed.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                    portalRed.transform.Rotate(portalRed.transform.up, -90);
                    currentSurfaceRed = "Wall 4";
                    currentPortal = 1;
                }
                else
                {
                    portalBlue.transform.position = new Vector3(px, py, pz);
                    portalBlue.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                    portalBlue.transform.Rotate(portalBlue.transform.up, 90);
                    currentSurfaceBlue = "Wall 4";
                    currentPortal = 0;
                }
            }

            else if (hit.transform.name == "Roof")
            {
                // positions
                float px = hit.point.x;
                float py = hit.point.y - portalOffset;
                float pz = hit.point.z;

                if (currentPortal == 0)
                {
                    portalRed.transform.position = new Vector3(px, py, pz);
                    portalRed.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                    portalRed.transform.Rotate(portalRed.transform.right, -90);
                    currentSurfaceRed = "Roof";
                    currentPortal = 1;
                }
                else
                {
                    portalBlue.transform.position = new Vector3(px, py, pz);
                    portalBlue.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                    portalBlue.transform.Rotate(portalBlue.transform.right, 90);
                    currentSurfaceBlue = "Roof";
                    currentPortal = 0;
                }
            }

            else if (hit.transform.name == "Floor")
            {
                // positions
                float px = hit.point.x;
                float py = hit.point.y + portalOffset;
                float pz = hit.point.z;

                if (currentPortal == 0)
                {
                    portalRed.transform.position = new Vector3(px, py, pz);
                    portalRed.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                    portalRed.transform.Rotate(portalRed.transform.right, 90);
                    currentSurfaceRed = "Floor";
                    currentPortal = 1;
                }
                else
                {
                    portalBlue.transform.position = new Vector3(px, py, pz);
                    portalBlue.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                    portalBlue.transform.Rotate(portalBlue.transform.right, -90);
                    currentSurfaceBlue = "Floor";
                    currentPortal = 0;
                }
            }
        }
    }
}
