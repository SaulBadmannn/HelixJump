using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBuilder : MonoBehaviour
{
    [SerializeField] private Ball _ball;

   public Ball BuildBall(Transform spawnPoint)
    {
        Ball ball = Instantiate(_ball, spawnPoint.position, Quaternion.identity);

        return ball;
    }
}
