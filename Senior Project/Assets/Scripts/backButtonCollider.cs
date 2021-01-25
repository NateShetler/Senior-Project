// Nathaniel Shetler
// 25 January 2020
// Senior Honors Project

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backButtonCollider : MonoBehaviour
{
    // For the back button animator
    private Animator backButtonAnimator;

    // Start is called before the first frame update
    void Start()
    {
        // Set up the back button animator
        backButtonAnimator = GameObject.Find("Back Button").GetComponent<Animator>();
    }

    // This function will detect when the button reaches the collider
    // When the button reaches the collider (or the apex of its movement, the animation 
    // trigger will be reset.
    void OnTriggerEnter(Collider other)
    {

        // Make sure that the object colliding is the button
        if (other.tag == "Push Button")
        {
            // Turn the button animation trigger off
            backButtonAnimator.ResetTrigger("Back Button Touch");
        }
    }
}
