using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baricade : MonoBehaviour
{
    public GameObject bar;
    private bool locked = false;
    private AudioSource AU;
	// Use this for initialization

    void Start () {
        AU = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
    {
       
	}
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Lock") // if the lock is in the trigger set locked to false
        {
            locked = false;
        }
       
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Room1Lock" || other.gameObject.tag == "Room2Lock" ) // if the lock exits the trigger then set lock to true and play animations and audio then destroy the baricade
        {
            locked = true;
            AU.Play();
            this.GetComponent<Animator>().SetTrigger("Open");
            Destroy(this.gameObject, 3);
            Destroy(bar,3);
        }
    }
}
