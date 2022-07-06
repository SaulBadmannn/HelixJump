using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] private LevelBuilder _levelBuilder;
    [SerializeField] private EndCard _endCard;

    private FinishPlatform _finishPlatform;

    private void Awake()
    {
        _levelBuilder.BuildLevel(out _finishPlatform);
        _endCard.SubscribeFinishEvent(_finishPlatform);
    }
}
