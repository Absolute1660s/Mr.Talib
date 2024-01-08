using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLımıt : MonoBehaviour
{
    public Transform target;
    public Vector2 minLimit;
    public Vector2 maxLimit;

    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 targetPosition = target.position;

            targetPosition.x = Mathf.Clamp(targetPosition.x, minLimit.x, maxLimit.x);
            targetPosition.y = Mathf.Clamp(targetPosition.y, minLimit.y, maxLimit.y);

            transform.position = new Vector3(targetPosition.x, targetPosition.y, transform.position.z);
        }
    }
}