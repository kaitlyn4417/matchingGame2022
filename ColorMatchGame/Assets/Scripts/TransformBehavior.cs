using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TransformBehavior : MonoBehaviour
{
    public void ResetToZero()
    {
        transform.position = Vector3.zero;
    }
}
