using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

using UnityEngine.SceneManagement;

public class backToOriginalScene : MonoBehaviour
{
    // This will change scenes if the book is touched.
    void OnTriggerEnter(Collider other)
    {
        // If the other game object (hand/player) collides with the book
        //if (other.tag == "Book Collider")
        //{
            // Load the book reader scene (index 1)
            SceneManager.LoadScene(0);
        //}
    }
}