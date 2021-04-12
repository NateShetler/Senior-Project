// Nathaniel Shetler
// 11 April 2021
// Senior Honors Project

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtilleryAnimation : MonoBehaviour
{
    // For the button animator
    private Animator buttonAnimator;

    // For the artillery
    private Animator artilleryAnimator;

    public ParticleSystem explosionEffect;

    // Start is called before the first frame update
    void Start()
    {
        // Set up the animators
        buttonAnimator = GetComponent<Animator>();
        artilleryAnimator = GameObject.Find("Artillery_V1").GetComponent<Animator>();
    }

    // To detect anything touching the button
    void OnTriggerEnter(Collider other)
    {

        if (other.tag != "Push Button") // If the item touching the button is the button collider
        {
            // Set the triggers so that the animation occurs
            buttonAnimator.SetTrigger("Artillery Button Touch");
            artilleryAnimator.SetTrigger("Fire Artillery");
            explosionEffect.Play();
        }

    }
}
