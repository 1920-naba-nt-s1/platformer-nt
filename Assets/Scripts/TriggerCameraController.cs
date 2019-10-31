using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class TriggerCameraController : MonoBehaviour
{
    public CinemachineVirtualCamera shot;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        shot.gameObject.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        shot.gameObject.SetActive(false);
    }

}
