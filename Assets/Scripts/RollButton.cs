using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RollButton : MonoBehaviour
{
    public Boolean rollButtonPress = false;
    public Boolean pressRoll = false;
    private int button;
    public Button m_YourFirstButton;
    public GameObject dice1, dice2;
    public GameObject player1;
    public GameObject player2;

    public int totalDice;

    void Start()
    {
        m_YourFirstButton.onClick.AddListener(TaskOnClick);
        
    }

    void TaskOnClick()
    {
        totalDice = 0;
        rollButtonPress = true;
        StartCoroutine(dice1.GetComponent<Dice>().Roll());
        StartCoroutine(dice2.GetComponent<Dice>().Roll());
        totalDice = dice1.GetComponent<Dice>().value + dice2.GetComponent<Dice>().value;
    }

}
