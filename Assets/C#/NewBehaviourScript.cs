  using System.Collections;
using System.Collections.Generic;
using System.Text;
using Unity.VisualScripting;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
   
    public float sorat ;
public float sens ;
    public Transform ori;
     public float run;
    
     float xrot;
     float yrot;
     Rigidbody rg;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        rg=GetComponent<Rigidbody>();
        rg.freezeRotation=true;
    }

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(new Vector3(0,Input.GetAxis("Mouse X")* sens *Time.deltaTime)); 
       

    }
    void FixedUpdate() {
        if(Input.GetKey(KeyCode.D)){
            transform.Translate (new Vector3(sorat*Time.deltaTime,0,0));
             
        }
        
     if(Input.GetKey(KeyCode.A)){
            transform.Translate (new Vector3(-sorat*Time.deltaTime,0,0));
        }
    if(Input.GetKey(KeyCode.S)){
            transform.Translate (new Vector3(0,0,-sorat*Time.deltaTime));  
        }
    if(Input.GetKey(KeyCode.W)){
            transform.Translate (new Vector3(0,0,sorat*Time.deltaTime));
            if (Input.GetKey(KeyCode.LeftShift)){
                transform.Translate (new Vector3(0,0,sorat*run*Time.deltaTime));
            }
    }
if(Input.GetKeyDown(KeyCode.Space)){
                rg.velocity=new Vector3 (rg.velocity.x,5f,rg.velocity.z);
        }
        else 
    {


}

   
    }
  
    }

