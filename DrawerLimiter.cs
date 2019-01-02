using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerLimiter : MonoBehaviour {

    public Transform min, max;

    private Quaternion originalPos;

	// Use this for initialization
	void Start () {
        originalPos = this.transform.rotation;
	}
	
	// Update is called once per frame
	void Update () // used to stop the draw exceeding the minimum and maximum push values
    {
        if (this.transform.position.x < min.transform.position.x)
        {
            this.transform.position = min.transform.position;
        }
        else if(this.transform.position.x > max.transform.position.x)
        {
            this.transform.position = max.transform.position;
        }
        this.transform.rotation = Quaternion.Euler(new Vector3(-90,0,0));
	}
}
