using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal  // note that this extends animal, not Monobehavior because it inherits Monobehavior
{
    // each child can call the script in the parent


    public override void MakeSound()  // accesses the function in the main script and tells it what to do.
    {
        
        tellPlayer.text = "I say Meow";
    }
}
