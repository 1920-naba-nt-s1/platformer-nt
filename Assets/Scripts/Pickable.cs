using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour
{

    // The jump bonus added to the character
    public float jumpBonus = 20;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger enter: " + collision.gameObject.name);

        GameObject go = collision.gameObject;
        RobotController robotController = go.GetComponent<RobotController>();
        if(robotController != null)
        {
            robotController.jumpMultiplier = jumpBonus;
        }

        // Removes the object omce it has been picked up
        Destroy(gameObject);
    }

}
