using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpatialEnlargement : MonoBehaviour
{
    public bool applySpatialEnlargement = true;
    public int spatialExpantionP = 2;
    public int spatialExpantionR = 2;

    public FPSController fpsScript;
    
    // Start is called before the first frame update
    void Start()
    {
        if (applySpatialEnlargement)
        {
            fpsScript.walkSpeed += spatialExpantionP;
            fpsScript.runSpeed += spatialExpantionP;
            fpsScript.mouseSensitivity += spatialExpantionR;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
