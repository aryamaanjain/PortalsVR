using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 curPosition = transform.position;
        if (curPosition.y < -0.2)
        {
            Debug.Log("Fall");
            transform.position = new Vector3(curPosition.x, 1.0f, curPosition.z);
        }
    }
}
