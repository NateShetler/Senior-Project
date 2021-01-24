using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.SceneManagement;

public class forwardPageButton : MonoBehaviour
{

    // Used for detecting forward button press
    public bool forwardPressed = false;

    // For the button animator
    private Animator buttonAnimator;

    // Start is called before the first frame update
    void Start()
    {
        // Set up the button animator
        buttonAnimator = GameObject.Find("Forward Button").GetComponent<Animator>();

    }

    // To detect the button press
    // This function runs when an object with a trigger contacts another object
    void OnTriggerEnter(Collider other)
    {

        // Make sure that the object colliding is the button
        if (other.tag == "Push Button")
        {
            // Set forwardPressed to true because the button was hit
            setForwardPressed(true);

            // Turn the button animation trigger off
            buttonAnimator.ResetTrigger("Button Touch");
        } 
    }

    // Setter function for the forward pressed boolean
    // Pre: This function accepts a boolean value
    // Post: This function sets forwardPressed to the value passed to it
    public void setForwardPressed(bool newValue)
    {
        forwardPressed = newValue;
    }

    // Getter function for forward pressed boolean 
    // Pre: N/A
    // Post: This function returns the forwardPressed boolean
    public bool getForwardPressed()
    {
        return forwardPressed;
    }

}