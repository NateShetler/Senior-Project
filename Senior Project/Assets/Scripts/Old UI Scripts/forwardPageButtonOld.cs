using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.SceneManagement;

public class forwardPageButtonOld : MonoBehaviour
{

    // Used for detecting forward button press
    public bool forwardPressed = false;

    void OnTriggerEnter(Collider other)
    {
        // Slight pause so button can "reset"
        System.Threading.Thread.Sleep(10);

        if (other.tag == "Push Button")
        {
            //SceneManager.LoadScene(1);

            // Set forwardPressed to true because the button was hit
            forwardPressed = true;
        }
    }
}