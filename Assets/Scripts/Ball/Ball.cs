using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Ball : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out PlatformSegment platformSegment))
        {
            other.GetComponentInParent<Platform>().Break();
        }
    }
}
