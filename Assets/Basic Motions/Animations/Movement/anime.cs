using System.Collections;
using System.Collections.Generic;
using UnityEngine;
     

public class anime : MonoBehaviour
{
    public GameObject DummyRig;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)&& Input.GetKey(KeyCode.LeftShift)){
           run1(); 
        }
        if (Input.GetKey(KeyCode.W)&&!Input.GetKey(KeyCode.LeftShift)){
           walik();
        }
        
        
        if (Input.GetKeyDown(KeyCode.A)){
            DummyRig.GetComponent<Animator>().Play("BasicMotions@Walk01 - Left");
        }
        
        if (Input.GetKeyDown(KeyCode.D)){
            DummyRig.GetComponent<Animator>().Play("BasicMotions@Walk01 - Right");
        }
        
        if (Input.GetKeyDown(KeyCode.S)){
            Backward();
        }
       else if(Input.GetKeyUp(KeyCode.W)|| Input.GetKeyUp(KeyCode.LeftShift)||Input.GetKeyUp(KeyCode.S)||Input.GetKeyUp(KeyCode.D)||Input.GetKeyUp(KeyCode.A)) {
            DummyRig.GetComponent<Animator>().Play("BasicMotions@Idle01");
            
        }
    }
    void walik(){
        DummyRig.GetComponent<Animator>().Play("BasicMotions@Walk01 - Forwards");
    }
    void Backward(){
        DummyRig.GetComponent<Animator>().Play("BasicMotions@Walk01 - Backwards");
    }
    void run1(){
        DummyRig.GetComponent<Animator>().Play("BasicMotions@Run01 - Forwards");

    }
}
