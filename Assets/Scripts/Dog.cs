using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    // can you call this function with the value below?
    public override void MakeSound()  // accesses the function in the main script and tells it what to do.
    {
        Debug.Log("woof" + Name);
    }
}
