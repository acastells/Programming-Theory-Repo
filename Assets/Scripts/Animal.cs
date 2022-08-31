using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Animator))]


public class Animal : MonoBehaviour
{
    public float movementSpeed { set; get; }
    public float jumpForce { set; get; }
    public float timeBeforeNextJump { set; get; }

    // ENCAPSULATION
    public string cleanedTextName = "";
    public string textName
    {
        get { return cleanedTextName; }
        set
        {
            if (value.Length > 6)
            {
                Debug.LogWarning("Name " + value + " is unnecessary long");
            }
            cleanedTextName = value;
        }
    }
    private float canJump = 0f;
    Animator anim;
    Rigidbody rb;
    TextMesh textMesh;
    AudioSource audioSource;

    void Start() // ABSTRACTION
    {
        setBehaviour();
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        textMesh = GetComponentInChildren<TextMesh>();
        audioSource = GetComponentInChildren<AudioSource>();
        textMesh.text = cleanedTextName;
        Talk();
    }

    // Update is called once per frame
    void Update() // ABSTRACTION
    {
        Jump();
        Walk();
    }

    public virtual void setBehaviour()
    {  //INHERITANCE, AS IT IS IMPLEMENTED ON THEIR CHILD CLASSES
        Debug.LogError("Not implemented");
    }

    public virtual void Talk()
    {
        audioSource.Play();
    }
    public virtual void Jump()
    {
        if (Time.time > canJump)
        {
            rb.AddForce(0, jumpForce, 0);
            canJump = Time.time + timeBeforeNextJump;
            anim.SetTrigger("jump");
        }
    }
    public virtual void Walk()
    {
        Vector3 movement = new Vector3(0f, 0.0f, 1f);
        anim.SetInteger("Walk", 1);
        transform.Translate(movement * movementSpeed * Time.deltaTime, Space.World);
    }

}
