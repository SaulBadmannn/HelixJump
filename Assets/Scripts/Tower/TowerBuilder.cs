using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBuilder : MonoBehaviour
{
    [SerializeField] private Transform _towerPoint;
    [SerializeField] private int _levelCount;
    [SerializeField] private float _additionalScale;
    [SerializeField] private GameObject _beam;
    [SerializeField] private SpawnPlatform _spawnPlatform;
    [SerializeField] private Platform[] _platforms;
    [SerializeField] private FinishPlatform _templateFinishPlatform;

    private float _startAndFinishAdditionalScale = 0.5f;

    public float BeamScaleY => _levelCount / 2f + _startAndFinishAdditionalScale + _additionalScale / 2f;

    public void BuildTower(out Transform spawnPointBall, out FinishPlatform finishPlatform)
    {
        GameObject beam = Instantiate(_beam, _towerPoint);
        beam.transform.localScale = new Vector3(1, BeamScaleY, 1);

        Vector3 spawnPosition = beam.transform.position;
        spawnPosition.y += beam.transform.localScale.y - _additionalScale;

        SpawnPlatform spawnPlatform = SpawnPlatform(_spawnPlatform, ref spawnPosition, beam.transform);

        spawnPointBall = spawnPlatform.GetSpawnPoint();

        for (int i = 0; i < _levelCount; i++)
        {
            SpawnPlatform(_platforms[Random.Range(0, _platforms.Length)], ref spawnPosition, beam.transform);
        }

        finishPlatform = SpawnPlatform(_templateFinishPlatform, ref spawnPosition, beam.transform);
    }

    private Platform SpawnPlatform(Platform platform, ref Vector3 spawnPosition, Transform parent)
    {
        Platform newPlatform = Instantiate(platform, spawnPosition, Quaternion.Euler(0, Random.Range(0, 360), 0), parent);
        spawnPosition.y -= 1;

        return newPlatform;
    }

    private SpawnPlatform SpawnPlatform(SpawnPlatform platform, ref Vector3 spawnPosition, Transform parent)
    {
        SpawnPlatform newPlatform = Instantiate(platform, spawnPosition, Quaternion.Euler(0, Random.Range(0, 360), 0), parent);
        spawnPosition.y -= 1;

        return newPlatform;
    }

    private FinishPlatform SpawnPlatform(FinishPlatform platform, ref Vector3 spawnPosition, Transform parent)
    {
        FinishPlatform newPlatform = Instantiate(platform, spawnPosition, Quaternion.Euler(0, Random.Range(0, 360), 0), parent);
        spawnPosition.y -= 1;

        return newPlatform;
    }
}
