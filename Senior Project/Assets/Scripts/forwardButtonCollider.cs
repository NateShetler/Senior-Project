// Nathaniel Shetler
// 25 January 2020
// Senior Honors Project

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forwardButtonCollider : MonoBehaviour
{
    // For the forward button animator
    private Animator forwardButtonAnimator;

    // Start is called before the first frame update
    void Start()
    {
        // Set up the forward button animator
        forwardButtonAnimator = GameObject.Find("Forward Button").GetComponent<Animator>();
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
            forwardButtonAnimator.ResetTrigger("Forward Button Touch");
        }
    }
}
