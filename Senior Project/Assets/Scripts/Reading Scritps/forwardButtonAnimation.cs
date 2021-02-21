// Nathaniel Shetler
// 25 January 2020
// Senior Honors Project

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script contains the logic previously found in the 'forwardPageButton.cs' script
// with additional logic added for the button animation

public class forwardButtonAnimation : MonoBehaviour
{
    // For the button animator
    private Animator buttonAnimator;

    // Used for detecting forward button press
    private bool forwardPressed = false;

    // Start is called before the first frame update
    void Start()
    {
        // Set up the button animator
        buttonAnimator = GetComponent<Animator>();
    }
    
    // To detect anything touching the button
    void OnTriggerEnter(Collider other)
    {
  
        if (other.tag == "Push Button") // If the item touching the button is the button collider
        {
            // Set forwardPressed to true because the button was hit
            setForwardPressed(true);
        }
        else // Otherwise, make the animation run
        {
            // Set the trigger so that the animation occurs
            buttonAnimator.SetTrigger("Forward Button Touch");
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
