using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform point1;
    public Transform point2;
    Camera cam;
    bool at1 = false;
    // Start is called before the first frame update
    void Start()
    {
       
        cam = Camera.main;
        
      
    }

    // Update is called once per frame
    void Update()
    {
        if (at1 == true)
        {
            
            cam.transform.position = Vector3.MoveTowards(cam.transform.position, point2.transform.position, 0.1f);
            at1 = false;

        } else if (at1 == false)
        {
           cam.transform.position = Vector3.MoveTowards(cam.transform.position, point1.transform.position, 0.1f);
            at1 = true;
        }
    }
}

