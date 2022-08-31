using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : Animal //INHERITANCE
{
    public override void setBehaviour() //POLYMORPHISM
    {
        movementSpeed = 4.5f;
        jumpForce = 100f;
        timeBeforeNextJump = 0.5f;
        textName = StartSceneManager.Instance.chickenName;
    }
}
