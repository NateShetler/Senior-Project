// Nathaniel Shetler
// 11 April 2021
// Senior Honors Project

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArtilleryButtonCollider : MonoBehaviour
{
    // For the artillery button animator
    private Animator artilleryButtonAnimator;

    // For the artillery
    private Animator artilleryAnimator;

    // For the audio
    private AudioSource explosion;

    // Start is called before the first frame update
    void Start()
    {
        // Set up the animators
        artilleryButtonAnimator = GameObject.Find("Artillery Button").GetComponent<Animator>();
        artilleryAnimator = GameObject.Find("Artillery_V1").GetComponent<Animator>();

        // Set up Audio Source
        explosion = GameObject.Find("Artillery_V1").GetComponent<AudioSource>();
    }

    // This function will detect when the button reaches the collider
    // When the button reaches the collider (or the apex of its movement, the animation 
    // trigger will be reset.
    void OnTriggerEnter(Collider other)
    {

        // Make sure that the object colliding is the button
        if (other.tag == "Push Button")
        {
            // Turn the button animation triggers off
            artilleryButtonAnimator.ResetTrigger("Artillery Button Touch");
            artilleryAnimator.ResetTrigger("Fire Artillery");
            explosion.Play(0);
        }
    }
}
