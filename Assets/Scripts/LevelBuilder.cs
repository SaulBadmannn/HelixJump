using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelBuilder : MonoBehaviour
{
    [SerializeField] private TowerBuilder _towerBuilder;
    [SerializeField] private Transform _towerPoint;
    [SerializeField] private BallBuilder _ballBuilder;

    private Transform _spawnPointBall;
    private Ball _ball;

    private void Awake()
    {
        _towerBuilder.BuildTower(_towerPoint);
        _spawnPointBall = _towerBuilder.GetSpawnPointBall();
        _ball = _ballBuilder.BuildBall(_spawnPointBall);
    }

    public Ball GetBall()
    {
        return _ball;
    }  

}
