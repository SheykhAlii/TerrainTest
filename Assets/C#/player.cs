using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEditor.Callbacks;
using UnityEngine;

public class player : MonoBehaviour
{
    public float sens;
    public float sorat;
     Rigidbody rg;
     bool grondchek;
     public LayerMask ground ;

    
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
        grondchek= Physics.Raycast(transform.position ,Vector3.down,1 ,ground);
        transform.Rotate(new Vector3(0,Input.GetAxis("Mouse X")* sens *Time.deltaTime)); 
        Speedcontroll();
    }
    void FixedUpdate() {
        if(Input.GetKey(KeyCode.W)){
            rg.AddForce(transform.forward*sorat*5f,ForceMode.Force);
            if (Input.GetKey(KeyCode.LeftShift)){
                rg.AddForce(transform.forward*sorat*6f,ForceMode.Force);
                
            }
        }
        
     if(Input.GetKey(KeyCode.S)){
            rg.AddForce(transform.forward*-sorat*10f,ForceMode.Force);
        }
    if(Input.GetKey(KeyCode.A)){
            rg.AddForce(transform.right*-sorat*10f,ForceMode.Force);
            
        }
    if(Input.GetKey(KeyCode.D)){
            rg.AddForce(transform.right*sorat*10f,ForceMode.Force);
            
            }
if(Input.GetKey(KeyCode.Space)){
                rg.AddForce(transform.up*sorat*10f,ForceMode.Force);
        }
        else 
    {

    }
    }
    private void Speedcontroll (){
    
    Vector3 flatwel=new Vector3 (rg.velocity.x,0f,rg.velocity.z);
    if (flatwel.magnitude>sorat){
        Vector3 limit = flatwel.normalized*sorat;
        rg.velocity=new Vector3(limit.x,0f,limit.z);

    }

    }
    

}
