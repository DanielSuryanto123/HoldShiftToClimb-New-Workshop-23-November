using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAMERAFOLLOW : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void LateUpdate ()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smootheddPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smootheddPosition;

        transform.LookAt(target);
    }
}
