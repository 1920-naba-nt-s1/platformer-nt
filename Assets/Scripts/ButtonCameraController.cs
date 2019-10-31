using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ButtonCameraController : MonoBehaviour
{

    public CinemachineVirtualCamera shot;

    // Update is called once per frame
    void Update()
    {
        bool cameraEnabled = Input.GetKey(KeyCode.Alpha1);
        shot.gameObject.SetActive(cameraEnabled);
    }
}
