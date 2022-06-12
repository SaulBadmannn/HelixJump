using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FinishPlatform : Platform
{
    public event UnityAction LevelPassed;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Ball ball))
        {
            Debug.Log("Мяч коснулся финиша");
            LevelPassed?.Invoke();
        }
    }
}
