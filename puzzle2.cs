using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle2 : MonoBehaviour
{// first attempt at script for puzzle 2 no longer used
    public GameObject[] buttons;
    public GameObject safe;
    private int count = 0;
    private int wrongNumbers;
    private bool wrong = false;
    private bool reset= false;
    public int[] Playercode;
    protected int pressedNum;
    protected int Numberbutton= 0;
    protected bool pressed;

    private void Awake()
    {
       
        for(int k=0;k < 4; k++)
        {
            Playercode[k] = 4;
        }
    }

    private void Update()
    {
        if(pressed == true)
        {
            Playercode[Numberbutton-1] = pressedNum;
            pressed = false;
        }
        if(Numberbutton == 5)
        {
            Numberbutton = 0;
        }

        for(int i = 0; i<4; i++)
        {
            if (Playercode[i] == i)
            {
                count++;
                Debug.Log(count);
            }
            else count = 0;
            

        }

        for(int m=0; m<4;m++)
        {
            if(Playercode[m] != 4 && Playercode[m] != m)
            {
                wrongNumbers++;
            }

        }

        if (wrongNumbers == 4 && count != 4)
        {
            wrong = true;
            reset = true;
        }

        if(wrong == true && reset == true)
        {
            for(int j =0; j<4; j++)
            {
                Playercode[j] = 4;
                wrong = false;
                reset = false;
                count = 0;
                wrongNumbers = 0;
            }
        }
        if(count == 4)
        {
            safe.GetComponent<Animator>().SetBool("open", true);
        }
    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    if(other.gameObject.tag == "0")
    //    {
    //        pressedNum = 0;
    //        Numberbutton++;
    //        pressed = true;
    //    }
    //    if (other.gameObject.tag == "1")
    //    {
    //        pressed = true;
    //        pressedNum = 1;
    //        Numberbutton++;
    //    }
    //    if (other.gameObject.tag == "2")
    //    {
    //        pressed = true;
    //        pressedNum = 2;
    //        Numberbutton++;
    //    }
    //    if (other.gameObject.tag == "3")
    //    {
    //        pressed = true;
    //        pressedNum = 3;
    //        Numberbutton++;
    //    }
    //}
    

}
