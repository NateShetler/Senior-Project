using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireArtillery : MonoBehaviour
{
    private Animator artilleryAnimator;

    // Start is called before the first frame update
    void Start()
    {
        // Set up the artillery animator
        artilleryAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        // If the other game object (hand/player) collides with the button
        if (other.tag == "Push Button")
        {
            // Set the trigger so that the animation occurs
            artilleryAnimator.SetTrigger("Fire Artillery");

        }
    }
}
