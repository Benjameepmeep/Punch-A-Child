using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerTest : MonoBehaviour
{
    public Transform target;
    public Vector3 posOffset;
    public float smooth;

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + posOffset, smooth * Time.deltaTime);
    }
}
