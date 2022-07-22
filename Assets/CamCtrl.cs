﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CamCtrl : MonoBehaviour
{
    private Camera cam;
    private Vector3 startPos;
    private Vector3 startAngle;
 
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
    }
 
    // Update is called once per frame
    void Update()
    {
        if (cam == null)
        {
            return;
        }
 
        float sensitiveMove = 0.8f;
        float sensitiveRotate = 5.0f;
        float sensitiveZoom = 10.0f;
   
        
            // rotate camera
            float rotateX = Input.GetAxis("Mouse X") * sensitiveRotate;
            float rotateY = Input.GetAxis("Mouse Y") * sensitiveRotate;
            cam.transform.Rotate(rotateY, rotateX, 0.0f);
        
 
        // zoom camera
        float moveZ = Input.GetAxis("Mouse ScrollWheel") * sensitiveZoom;
        cam.transform.position += cam.transform.forward * moveZ;
    }
}