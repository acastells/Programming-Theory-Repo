using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal //INHERITANCE
{
    public override void setBehaviour() //POLYMORPHISM
    {
        movementSpeed = 4.75f;
        jumpForce = 300f;
        timeBeforeNextJump = 1f;
        textName = StartSceneManager.Instance.catName;
    }
}
