// This script was built for a combination assignment between Game Design PA3 and my Honors Reasearch Project as desired by Dr. Xiao.
// This script was built with assistance from the one provided by Dr. Xiao for Game Design PA3. 
// A link to what was provided can be found here: http://wiki.unity3d.com/index.php?title=Flocking which is part of: https://creativecommons.org/licenses/by-sa/3.0/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdFlocking : MonoBehaviour
{
    internal BirdController controller;

    const int maxVelocity = 3;
    const int minVelocity = 1;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (true)
        {
            // Move the bird
            GetComponent<Rigidbody>().velocity += moveBird() * Time.deltaTime;

            if (GetComponent<Rigidbody>().velocity.magnitude > maxVelocity)
            {
                GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity.normalized * maxVelocity;
            }
            else if (GetComponent<Rigidbody>().velocity.magnitude < minVelocity)
            {
                GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity.normalized * minVelocity;
            }

            float waitTime = Random.Range(0.3f, 0.5f);
            yield return new WaitForSeconds(waitTime);
        }
    }

    // To aid in bird movement
    Vector3 moveBird()
    {
        // For randomized movement, except x stays the same to keep the bird upright
        Vector3 randomized = new Vector3(0, (Random.value * 2) - 1, (Random.value * 2) - 1);

        // Set center, velocity, follow 
        Vector3 center = transform.localPosition;
        Vector3 velocity = GetComponent<Rigidbody>().velocity;
        Vector3 follow = transform.localPosition;

        if (controller)
        {
            center = controller.flockCenter - transform.localPosition;
            velocity = controller.flockVelocity - GetComponent<Rigidbody>().velocity;
            follow = controller.flockAroundThisObject.localPosition - transform.localPosition;
        }

        return (center + velocity + follow * 8 + randomized);
    }
}
