using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class InformLevelPassed : MonoBehaviour
{
    [SerializeField] private TMP_Text _message;
    [SerializeField] private LevelBuilder _levelBuilder;
    
    private FinishPlatform _finishPlatform;
    

    private void Awake()
    {
        _message.text = "";
    }

    private void Start()
    {
        _finishPlatform = _levelBuilder.GetFinishPlatform();
        Debug.Log("Подписались");
        _finishPlatform.LevelPassed += OnLevelPassed;
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
