using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelBuilder : MonoBehaviour
{

    [SerializeField] private TowerBuilder _towerBuilder;
    [SerializeField] private BallBuilder _ballBuilder;
    
    public void BuildLevel(out FinishPlatform finishPlatform)
    {
        Transform spawnPointBall;

        _towerBuilder.BuildTower(out spawnPointBall, out finishPlatform);
        _ballBuilder.BuildBall(spawnPointBall);
    }
}
