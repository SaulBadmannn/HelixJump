using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InformLevelPassed : MonoBehaviour
{
    [SerializeField] private BallJumper _ball;
    [SerializeField] private TMP_Text _message;

    private void Awake()
    {
        _message.text = "";
    }

    private void OnEnable()
    {
        _ball.LevelPassed += WriteLevelPassed;
    }

    private void OnDisable()
    {
        _ball.LevelPassed -= WriteLevelPassed;
    }

    public void WriteLevelPassed()
    {
        Debug.Log("Finish");
        _message.text = "Вы прошли уровень!";
    }
}
