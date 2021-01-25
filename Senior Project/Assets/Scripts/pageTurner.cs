// Nathaniel Shetler
// 25 January 2020
// Senior Honors Project

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
    private int pageCounter;

    // For the forward button animator
    private Animator forwardButtonAnimator;

    // Start is called before the first frame update
    void Start()
    {
        // Set up the forward button animator
        forwardButtonAnimator = GameObject.Find("Forward Button").GetComponent<Animator>();

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

        // Set the intial value of the page number
        setPageCounter(0);
    }

    // Update is called once per frame
    void Update()
    {

        // This if/if else statement will detect if either the forward button or back button were pressed, and react accordingly.
        if ((GameObject.Find("Forward Button").GetComponent<forwardButtonAnimation>().getForwardPressed()) == true) // This block will run if the forward button has been pressed
        {

            // If the counter is greater than the amount of pages, set it back to zero.
            // Otherwise increment the counter by 2 to "turn the page"
            if (getPageCounter() > pages.Count)
            {
                setPageCounter(0);
            }
            else
            {
                // Increment counter by 2
                incrementPageCounter();
            }

            // Make the next pages visible
            for (int i = 0; i < pages.Count; ++i)
            {
                if (i == getPageCounter())
                {
                    // Make page visible
                    pages[i].SetActive(true);
                }
                else if (i == (getPageCounter() + 1))
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

            // Turn the button 'off'
            GameObject.Find("Forward Button").GetComponent<forwardButtonAnimation>().setForwardPressed(false);

        }
        else if ((GameObject.Find("Back Button").GetComponent<backButtonAnimation>().getBackPressed()) == true) // This block will run if the back button has been pressed
        {
            // If the counter is less than or equal to 2, then make sure it doesn't go lower (to ensure that 'negative'
            // pages are not attempted to be rendered)
            // Otherwise, decrement the counter by 2 to 'turn the page'
            if (getPageCounter() <= 2)
            {
                setPageCounter(2);
            }
            else
            {
                // Decrement counter by 2
                decrementPageCounter();

            }

            // Make the next pages visible
            for (int i = 0; i < pages.Count; ++i)
            {
                if (i == (getPageCounter() - 1))
                {
                    // Make page visible
                    pages[i].SetActive(true);
                }
                else if (i == (getPageCounter() - 2))
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
            
            // Turn the button 'off'
            GameObject.Find("Back Button").GetComponent<backButtonAnimation>().setBackPressed(false);

        }
    }


    // Pre: N/A
    // Post: This function will increment the page counter by 2
    public void incrementPageCounter()
    {
        pageCounter += 2;
    }

    // Pre: N/A 
    // Post: This function will decrement the page counter by 2
    public void decrementPageCounter()
    {
        pageCounter -= 2;
    }

    // Pre: This function will accept an integer value
    // Post: This function will set the value of the page counter variable
    public void setPageCounter(int newValue)
    {
        pageCounter = newValue;
    }

    // Pre: N/A
    // Post: This function will return the value of the pageCounter variable
    public int getPageCounter()
    {
        return pageCounter;
    }
}
