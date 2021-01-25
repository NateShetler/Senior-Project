// Nathaniel Shetler
// 25 January 2020
// Senior Honors Project

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backButtonAnimation : MonoBehaviour
{
    // For the button animator
    private Animator backButtonAnimator;

    // Used for detecting forward button press
    private bool backPressed = false;

    // Start is called before the first frame update
    void Start()
    {
        // Set up the button animator
        backButtonAnimator = GetComponent<Animator>();
    }

    // To detect anything touching the button
    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Push Button") // If the item touching the button is the button collider
        {
            // Set forwardPressed to true because the button was hit
            setBackPressed(true);
        }
        else // Otherwise, make the animation run
        {
            // Set the trigger so that the animation occurs
            backButtonAnimator.SetTrigger("Back Button Touch");
        }

    }

    // Setter function for the forward pressed boolean
    // Pre: This function accepts a boolean value
    // Post: This function sets forwardPressed to the value passed to it
    public void setBackPressed(bool newValue)
    {
        backPressed = newValue;
    }

    // Getter function for forward pressed boolean 
    // Pre: N/A
    // Post: This function returns the forwardPressed boolean
    public bool getBackPressed()
    {
        return backPressed;
    }
}
