using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.SceneManagement;

public class pageTurnerOld : MonoBehaviour
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
    }

    // Update is called once per frame
    void Update()
    {
        if ((GameObject.Find("Button Collider").GetComponent<forwardPageButton>().forwardPressed) == true)
        {
            SceneManager.LoadScene(0);

            // Increment counter to "turn page" for next time function is called
            ++counter;

            if (counter > 10)
            {
                counter = 0;
            }

            for (int i = 0; i < pages.Count; ++i)
            {
                if (i == counter)
                {
                    // Make page visible
                    pages[counter].SetActive(true);
                }
                else if (i == counter + 1)
                {
                    // Make page visible
                    pages[counter].SetActive(true);
                }
                else
                {
                    // Make page invisible
                    pages[i].SetActive(false);
                }
            }

            GameObject.Find("Button Rectangle").GetComponent<forwardPageButton>().forwardPressed = false;
        }
    }
}
