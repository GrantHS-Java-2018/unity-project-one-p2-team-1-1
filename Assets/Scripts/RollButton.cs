using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RollButton : MonoBehaviour
{
    public Boolean rollButteonPress = false;
    public Boolean pressRoll = false
    private int button;
    public Button m_YourFirstButton;
    public GameObject dice1, dice2;
    public GameObject Player1;

    public int totalDice;

    void Start()
    {
        m_YourFirstButton.onClick.AddListener(TaskOnClick);
        
    }

    void TaskOnClick()
    {
        rollButtonPress = true;
        StartCoroutine(dice1.GetComponent<Dice>().Roll));
        StartCoroutine(dice2.GetComponent<Dice>().Roll));
        totalDice = dice1.Getcomponent<Dice>().value + dice2.getComponent<Dice>().value;
    }

}
