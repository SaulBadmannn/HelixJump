using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class EndCard : MonoBehaviour
{
    [SerializeField] private TMP_Text _message;
    private FinishPlatform _finishPlatform;

    private void Awake()
    {
        _message.text = "";
    }

    public void SubscribeFinishEvent(FinishPlatform finishPlatform)
    {
        _finishPlatform = finishPlatform;
        finishPlatform.LevelPassed += OnLevelPassed;
    }

    private void OnDisable()
    {
        _finishPlatform.LevelPassed -= OnLevelPassed;
    }

    public void OnLevelPassed()
    {
        Debug.Log("Finish");
        _message.text = "Вы прошли уровень!";
    }
}
