using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : Animal
{
    // Start is called before the first frame update
    public override void MakeSound()  // accesses the function in the main script and tells it what to do.
    {
        Debug.Log("Hisssss" + Name);
    }
}
