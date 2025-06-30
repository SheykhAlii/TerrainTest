using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkv3 : MonoBehaviour
{
    Rigidbody rb1;
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        rb1=GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0,Input.GetAxis("Mouse X")* 100 *Time.deltaTime));
        
    }
    void FixedUpdate(){
        float ver=Input.GetAxis("Vertical");
        float hor=Input.GetAxis("Horizontal");
         rb1.velocity=new Vector3(hor*speed,rb1.velocity.y,ver*speed);
    }
    }
    
