using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonPressAnimation : MonoBehaviour
{
    // For the button animator
    private Animator buttonAnimator;

    // Start is called before the first frame update
    void Start()
    {
        // Set up the button animator
        buttonAnimator = GetComponent<Animator>();
     
    }

    // To detect anything touching the button
    void OnTriggerEnter(Collider other)
    {
        // Set the trigger so that the animation occurs
        buttonAnimator.SetTrigger("Button Touch");
    }
}
