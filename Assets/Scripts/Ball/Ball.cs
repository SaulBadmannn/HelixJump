using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Ball : MonoBehaviour
{
    public event UnityAction LevelPassed;

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out PlatformSegment platformSegment))
        {
            other.GetComponentInParent<Platform>().Break();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out FinishPlatform finishPlatform))
        {
            Debug.Log("Мяч коснулся финиша");
            LevelPassed?.Invoke();
        }
    }
}
