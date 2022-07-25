using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CamCtrl : MonoBehaviour
{
    int a = 0;
    
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
        Transform myTransform = this.transform;
      Vector3 worldAngle = myTransform.eulerAngles;
        float sensitiveRotate = 1.3f;
        float world_angle_x = worldAngle.x;
        float world_angle_y = worldAngle.y;
        float world_angle_z = worldAngle.z;
        a =0;
        if (Input.GetMouseButton(1)){
            a = 1;
        }
        if(a == 1)
        {
            // rotate camera
            float rotateX = Input.GetAxis("Mouse X") * sensitiveRotate;
            float rotateY = Input.GetAxis("Mouse Y") * sensitiveRotate;
            
            cam.transform.Rotate(-rotateY, rotateX, -world_angle_z);
        }
        if(a == 0){
       cam.transform.rotation = Quaternion.Euler(-10,90,0);
        }
    }
}