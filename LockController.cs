using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockController : MonoBehaviour
{

    private Rigidbody rb;
    private BoxCollider bx;
	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        bx = GetComponent<BoxCollider>();
    }
	
	// Update is called once per frame
	void Update ()
    {
      
    }
   void OnTriggerEnter(Collider other) 
    { // if the appropriate tag is true then enable gravity and disable the trigger to make it a standered collider
        if (this.gameObject.tag == "Room1Lock" && other.gameObject.tag == "Room1Key")
        {
            rb.useGravity = true;
            bx.isTrigger = false;
             
        }
        if (this.gameObject.tag == "Room2Lock" && other.gameObject.tag == "Room2Key")
        {
            rb.useGravity = true;
            bx.isTrigger = false;

        }
        if (this.gameObject.tag == "Room3Lock" && other.gameObject.tag == "Room3Key")
        {
            rb.useGravity = true;
            bx.isTrigger = false;

        }
    }
}
