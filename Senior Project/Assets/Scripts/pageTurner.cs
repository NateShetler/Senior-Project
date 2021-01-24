using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.SceneManagement;

public class pageTurner : MonoBehaviour
{
    // This list will be used to store the pages of the book
    public List<GameObject> pages = new List<GameObject>();

    // To keep track of page
    public int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        // Make initial 2 pages visible
        for (int i = 0; i < pages.Count; ++i)
        {
            if (i == 0 || i == 1)
            {
                // Make page visible
                pages[i].SetActive(true);
            }
            else
            {
                // Make page invisible
                pages[i].SetActive(false);
            }
        }

        // Since the first two pages are visible, set counter to 2
        counter = 2;
    }

    // Update is called once per frame
    void Update()
    {

        // This block will run if the forward pressed button has been pressed
        if ((GameObject.Find("Button Collider").GetComponent<forwardPageButton>().getForwardPressed()) == true)
        {
            
            // Make the next pages visible
            for (int i = 0; i < pages.Count; ++i)
            {
                if (i == counter)
                {
                    // Make page visible
                    pages[i].SetActive(true);
                }
                else if (i == (counter + 1))
                {
                    // Make page visible
                    pages[i].SetActive(true);
                }
                else
                {
                    // Make page invisible
                    pages[i].SetActive(false);
                }
            }

            // Increment counter to "turn page" for next time function is called
            counter += 2;

            // If the counter is greater than the amount of pages, set it back to zero
            if (counter > pages.Count)
            {
                counter = 0;
            }

            // Turn the button 'off'
            GameObject.Find("Button Collider").GetComponent<forwardPageButton>().setForwardPressed(false);

        }
    }
}
