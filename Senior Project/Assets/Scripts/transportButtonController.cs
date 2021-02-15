using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transportButtonController : MonoBehaviour
{

    private Animator transportButtonAnimator;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the animator for the button
        transportButtonAnimator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        // If the correct page number has been reached, start the animation
        if ((GameObject.Find("Book").GetComponent<pageTurner>().GetPageCounter() == GameObject.Find("Book").GetComponent<pageTurner>().GetTransportButtonVisible()) ||
            (GameObject.Find("Book").GetComponent<pageTurner>().GetPageCounter() == (GameObject.Find("Book").GetComponent<pageTurner>().GetTransportButtonVisible() + 1)))
        {
            // Set the trigger to start the animation
            transportButtonAnimator.SetTrigger("Start Animation");
        }
    }
}
