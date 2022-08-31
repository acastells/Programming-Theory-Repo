using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal // INHERITANCE 
{
    public override void setBehaviour() //POLYMORPHISM
    {
        movementSpeed = 4.2f;
        jumpForce = 150f;
        timeBeforeNextJump = 2f;
        textName = "Doggo";
    }
}
