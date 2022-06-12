using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class InformLevelPassed : MonoBehaviour
{
    [SerializeField] private TMP_Text _message;
    [SerializeField] private LevelBuilder _levelBuilder;
    
    private Ball _ball;
    

    private void Awake()
    {
        _message.text = "";
    }

    private void Start()
    {
        _ball = _levelBuilder.GetBall();
        Debug.Log("Подписались");
        _ball.LevelPassed += OnLevelPassed;
    }

    private void OnDisable()
    {
        _ball.LevelPassed -= OnLevelPassed;
    }

    public void OnLevelPassed()
    {
        Debug.Log("Finish");
        _message.text = "Вы прошли уровень!";
    }
}
