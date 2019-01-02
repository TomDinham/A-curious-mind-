using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchController : MonoBehaviour
{
   public Light Pl;
   private bool grabbed = false;
	// Use this for initialization
	void Start () {
        //Pl = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(grabbed == true) // if grabbed allow the player to turn the tourch on and off using button b
        {
            if (OVRInput.GetDown(OVRInput.Button.Two) && Pl.intensity > 0)
            {
                Pl.intensity = 0;
            }
            else if(OVRInput.GetDown(OVRInput.Button.Two) && Pl.intensity <=0)
            {
                Pl.intensity = 1.5f;
            }
        }
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") // if the colliding objects tag is player then set grabbed to true, if not set it to false
        {
            grabbed = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            grabbed = false;
        }
    }
}

