using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class ButtonSceneChanger : MonoBehaviour
{
    // This will change scenes if the book is touched.
    void OnTriggerEnter(Collider other)
    {
        // If the other game object (hand/player) collides with the book
        if (other.tag == "Push Button")
        {
            // Load the book reader scene (index 2)
            SceneManager.LoadScene(2);
        }
    }
}