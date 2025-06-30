using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salam : MonoBehaviour
{
   
public float speed;
public Transform orientaion;
float horizon;
float vertical;
Vector3 moveDirec;
Rigidbody rg ;

    // Start is called before the first frame update
    void Start()
    {
        rg=GetComponent<Rigidbody>();
        rg.freezeRotation=true;

    }

    void Update()
    {
      horizon=Input.GetAxisRaw("Horizontal");
      vertical=Input.GetAxisRaw("Vertical");

        moveDirec =orientaion.forward*vertical + orientaion.right*horizon;
        rg.AddForce(moveDirec.normalized*speed*2f,ForceMode.Force);
    }
}
