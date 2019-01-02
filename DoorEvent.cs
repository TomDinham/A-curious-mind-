using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorEvent : MonoBehaviour
{
    private bool happened = true;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player" && happened == true)
        {
            GetComponent<Animation>().Play("CloseInteriorDoor");
            happened = false;
        }
    }
}
