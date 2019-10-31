using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ButtonCameraController : MonoBehaviour
{

    // The virtual camera to be activated/deactivated
    public CinemachineVirtualCamera shot;

    // Update is called once per frame
    void Update()
    {
        // If the key is down, activate the camera
        bool cameraEnabled = Input.GetKey(KeyCode.Alpha1);
        shot.gameObject.SetActive(cameraEnabled);
    }
}
