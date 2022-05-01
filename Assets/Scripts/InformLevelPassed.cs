using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class InformLevelPassed : MonoBehaviour
{
    [SerializeField] private BallJumper _ball;
    [SerializeField] private TMP_Text _message;

    /*private void Awake()
    {
        _message.text = "";
    }*/

    private void OnEnable()
    {
        Debug.Log("Подписались");
        _ball.LevelPassed += OnLevelPassed;
    }

    private void OnDisable()
    {
        _ball.LevelPassed -= OnLevelPassed;
    }

    private void OnLevelPassed()
    {
        Debug.Log("Finish");
        _message.text = "Вы прошли уровень!";
    }
}
