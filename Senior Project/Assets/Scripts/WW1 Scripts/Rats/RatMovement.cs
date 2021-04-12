// Nathaniel Shetler
// 11 April 2021
// Senior Honors Project

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatMovement : MonoBehaviour
{
    private const float maxVelocity = 0.7f;
    private const float minVelocity = 0.4f;

    private const float maxZ = 285.25f;
    private const float minZ = 284.658f;
    private const float maxX = 441.5f;
    private const float minX = 439f;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(minVelocity, maxVelocity), 0, Random.Range(-minVelocity, -maxVelocity));
    }

    // Update is called once per frame
    void Update()
    {
        // Move rat inside of the defined area
        if (transform.position.z > maxZ)
        {
            if (transform.position.x > maxX)
            {
                this.GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(-minVelocity, -maxVelocity), 0, Random.Range(-minVelocity, -maxVelocity));
            }
            else if (transform.position.x < minX)
            {
                this.GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(minVelocity, maxVelocity), 0, Random.Range(-minVelocity, -maxVelocity));
            }
        }
        else if (transform.position.z < minZ)
        {
            if (transform.position.x > maxX)
            {
                this.GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(-minVelocity, -maxVelocity), 0, Random.Range(minVelocity, maxVelocity));
            }
            else if (transform.position.x < minX)
            {
                this.GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(minVelocity, maxVelocity), 0, Random.Range(minVelocity, maxVelocity));
            }
        }
        else if (transform.position.x > maxX)
        {
            this.GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(-minVelocity, -maxVelocity), 0, this.GetComponent<Rigidbody>().velocity.z);
        }
        else if (transform.position.x < minX)
        {
            this.GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(minVelocity, maxVelocity), 0, this.GetComponent<Rigidbody>().velocity.z);
        }

        transform.right = this.GetComponent<Rigidbody>().velocity.normalized;

        if (this.GetComponent<Rigidbody>().velocity.x < 0.2f && this.GetComponent<Rigidbody>().velocity.x > 0)
        {
            this.GetComponent<Rigidbody>().velocity = new Vector3(this.GetComponent<Rigidbody>().velocity.x + 0.2f, this.GetComponent<Rigidbody>().velocity.y, this.GetComponent<Rigidbody>().velocity.z);
        }
        else if (this.GetComponent<Rigidbody>().velocity.x < 0 && this.GetComponent<Rigidbody>().velocity.x > -0.2f)
        {
            this.GetComponent<Rigidbody>().velocity = new Vector3(this.GetComponent<Rigidbody>().velocity.x - 0.2f, this.GetComponent<Rigidbody>().velocity.y, this.GetComponent<Rigidbody>().velocity.z);
        }
    }
}
