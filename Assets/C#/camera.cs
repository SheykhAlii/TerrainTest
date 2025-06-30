 using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;

public class camera : MonoBehaviour
{
    public float sensY;
    float m;
    public GameObject MainCamera;
    public float camerashake;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float mousey =Input.GetAxis("Mouse Y")* sensY*Time.deltaTime;
        m -= mousey;
        m=Mathf.Clamp(m,-90,90);
        transform.localEulerAngles=(new Vector3(m,0,0 ));
        if(Input.GetKey(KeyCode.W )&&Input.GetKey(KeyCode.LeftShift )){
        
        run();
    }
    else if (Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.S)||Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.A)){
     walk();
    }
    else
    {
        stopanime();
    }
}
 
    void walk (){
        MainCamera.GetComponent<Animator>().Play("New Animation");
    }
    void stopanime (){
        MainCamera.GetComponent<Animator>().Play("New State");
    } 
    void run(){
         MainCamera.GetComponent<Animator>().Play("run");
    }
}