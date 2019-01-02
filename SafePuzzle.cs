using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafePuzzle : MonoBehaviour
{
    string Correctcode = "0123";
     string Input = "";
    int maxCode = 4;
    public GameObject safe;
    private string currentButton;
    public AudioClip ButtonClick;
    public AudioClip Correct;
    public AudioClip wrongBuzz;
    private AudioSource AS;

	void Start ()
    {
        AS = GetComponent<AudioSource>();

		
	}
	

	void Update ()
    {
        //Debug.Log(Input + "Input is");
        if(Input.Length == maxCode) // checks if string is the safe length as the max code number 
        {
            checkCode();
        }
        if(Input.Length > maxCode) //checks if input string is longer than the max code, if it is then reset the input 
        {
            Input = "";
        }
		
	}
    void checkCode()
    {
        if (Correctcode == Input) // if the input is the same as the correct code, open safe, play audio and reset input 
        {
            safe.GetComponent<Animator>().SetBool("safe", true);
            AS.PlayOneShot(Correct);
            Input = "";
        }
        else
        {
            Input = ""; //if input is not the same as the correct code then reset the input and play the buzzer
            AS.PlayOneShot(wrongBuzz);
        }

    }
    private void OnCollisionEnter(Collision other)
    {
        currentButton = other.gameObject.tag;
        switch (currentButton) // switch on the tag and send the program to the coroutine function witht the inputed number
        {
            case "0":
                AS.PlayOneShot(ButtonClick); StartCoroutine(InputNumber());
                break;
            case "1":
                AS.PlayOneShot(ButtonClick); StartCoroutine(InputNumber());
                break;
            case "2":
                AS.PlayOneShot(ButtonClick); StartCoroutine(InputNumber());
                break;
            case "3":
                AS.PlayOneShot(ButtonClick); StartCoroutine(InputNumber());
                break;
            default:
                Debug.Log(other.gameObject.tag);
                break;
        }
       
    }
    IEnumerator InputNumber()
    {
        
        Input = Input + currentButton; // place the current button press into the input string
        yield return new WaitForSeconds(1);

    }
}
