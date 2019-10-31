using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour
{

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

        Destroy(gameObject);
    }

}
