using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class InformLevelPassed : MonoBehaviour
{
    private Ball _ball;
    [SerializeField] private TMP_Text _message;

    private void Awake()
    {
        _message.text = "";
    }

    private void Start()
    {
        _ball = FindObjectOfType<Ball>();
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
