using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScript : MonoBehaviour
{
    public Text winMessage;
    public Text instructions;

    // Start is called before the first frame update
    void Start()
    {
        winMessage.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // This will detect when the ball goes into the hole
    void OnCollisionEnter(Collision holeCol)
    {
        if (holeCol.gameObject.name == "Plane Under Hole")
        {
            // Tell the player they have won
            winMessage.text = "You have won!";

            // Get rid of the instructions text
            instructions.text = "";
        }
    }
}
