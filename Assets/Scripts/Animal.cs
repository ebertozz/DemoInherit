using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Animal : MonoBehaviour  // This script is not attached to anything. It holds the functions that the
    // children objects can execute so that you don't have to repeat them on other scripts.
{
    public string Name;    // string var to hold name
    public Text tellPlayer;  // text area to display name on screen

    

    void Start()
    {
        
       
        tellPlayer.text = "my name is " + Name;   // when game starts, each child displays own name
    }

    public virtual void MakeSound() // add virtual so it can be overridden from child script
    {
        Debug.Log("this is the generic message from Animal class");  // this message is never displayed
        // it is overwritten by the child objects that call the function.

    }
}
