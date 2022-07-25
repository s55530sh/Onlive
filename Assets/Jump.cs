using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Jump : MonoBehaviour
{
    public float jumpPower;
    private Rigidbody rb;
    private bool isJumping = false;
 
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
 
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            rb.velocity = Vector3.up * jumpPower;
            isJumping = true;
        }
    }
 
    // ★★追加
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }
}