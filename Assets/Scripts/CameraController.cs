using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraController : MonoBehaviour
{
    public CinemachineVirtualCamera camera1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool enableCamera1 = Input.GetKey(KeyCode.Alpha1);
        camera1.gameObject.SetActive(enableCamera1);
    }
}
