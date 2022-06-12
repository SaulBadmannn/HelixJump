using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatform : Platform
{
    [SerializeField] private Ball _ball;
    [SerializeField] private Transform _spawnPoint;

    public Transform GetSpawnPoint()
    {
        return _spawnPoint;
    }
}
