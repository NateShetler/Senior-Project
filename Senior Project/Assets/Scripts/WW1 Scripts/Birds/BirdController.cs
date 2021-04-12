// This script was built for a combination assignment between Game Design PA3 and my Honors Reasearch Project as desired by Dr. Xiao.
// This script was built with assistance from the one provided by Dr. Xiao for Game Design PA3. 
// A link to what was provided can be found here: http://wiki.unity3d.com/index.php?title=Flocking which is part of: https://creativecommons.org/licenses/by-sa/3.0/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public int flockSize = 20;
    public BirdFlocking birdObject;
    public Transform flockAroundThisObject;

    internal Vector3 flockCenter;
    internal Vector3 flockVelocity;
    List<BirdFlocking> birds = new List<BirdFlocking>();

    // This will reference the player character game object
    public GameObject playerCharacter;

    // This will house the offset between the player character and the flock
    private Vector3 playerFlockOffset;

    // Start is called before the first frame update
    void Start()
    {
        // Set the intial offset for the flock and player
        //playerFlockOffset = transform.position - playerCharacter.transform.position;
        playerFlockOffset = transform.position - flockAroundThisObject.transform.position;

        // Make the flock
        for (int i = 0; i < flockSize; ++i)
        {
            BirdFlocking bird = Instantiate(birdObject, transform.position, transform.rotation) as BirdFlocking;
            bird.transform.parent = transform;
            bird.transform.localPosition = new Vector3(Random.value * GetComponent<Collider>().bounds.size.x, Random.value * GetComponent<Collider>().bounds.size.y, Random.value * GetComponent<Collider>().bounds.size.z) - GetComponent<Collider>().bounds.extents;

            // Set bird controller to this controller
            bird.controller = this;

            // Add bird to flock
            birds.Add(bird);

        }
    }

    // Update is called once per frame
    void Update()
    {
        // Update the offset every frame so that the flock remains in the same
        // relative position in comparison to the player character
        transform.position = flockAroundThisObject.transform.position + playerFlockOffset;

        Vector3 center = new Vector3(0, 0, 0);
        Vector3 velocity = new Vector3(0, 0, 0);

        // Update each mosquito
        foreach (BirdFlocking bird in birds)
        {
            // Add to center
            center += bird.transform.localPosition;

            // Make sure that the flock doesn't go too far away from one another
            if (bird.transform.localPosition.y < transform.localPosition.y - 7)
            {
                bird.GetComponent<Rigidbody>().velocity = new Vector3(bird.GetComponent<Rigidbody>().velocity.x, bird.GetComponent<Rigidbody>().velocity.y + 0.01f, bird.GetComponent<Rigidbody>().velocity.z);
            }
            else if (bird.transform.localPosition.z > - 2)
            {
                bird.GetComponent<Rigidbody>().velocity = new Vector3(bird.GetComponent<Rigidbody>().velocity.x, bird.GetComponent<Rigidbody>().velocity.y, bird.GetComponent<Rigidbody>().velocity.z - 0.01f);
            }

            // Add to velocity
            velocity += bird.GetComponent<Rigidbody>().velocity;
        }

        // Set flock center and velocity
        flockCenter = center / flockSize;
        flockVelocity = velocity / flockSize;
    }
}
