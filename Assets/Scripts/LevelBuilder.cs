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
    private FinishPlatform _finishPlatform;

    private void Awake()
    {
        _towerBuilder.BuildTower(_towerPoint);

        _spawnPointBall = _towerBuilder.GetSpawnPointBall();
        _finishPlatform = _towerBuilder.GetFinishPlatform();

        _ballBuilder.BuildBall(_spawnPointBall);
    }

    public FinishPlatform GetFinishPlatform()
    {
        return _finishPlatform;
    }  

}
