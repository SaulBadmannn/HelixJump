using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody))]
public class BallJumper : MonoBehaviour
{
    [SerializeField] private float _jumpForce;

    private Rigidbody _rigidbody;

    public event UnityAction LevelPassed;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent(out PlatformSegment platformSegment))
        {
            _rigidbody.velocity = Vector3.zero;
            _rigidbody.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
        }
        else if(collision.gameObject.TryGetComponent(out FinishPlatform finishPlatform))
        {
            LevelPassed?.Invoke();
        }
    }
}
