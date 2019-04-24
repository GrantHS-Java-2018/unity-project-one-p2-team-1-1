using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RollButton : MonoBehaviour
{
    public Boolean rollButtonPress = false;
    public Boolean pressRoll = false
    private int button;
    public Button m_YourFirstButton;
    public GameObject dice1, dice2;
    public GameObject Player1;
    public GameObject Player2;

    public int totalDice;

    void Start()
    {
        m_YourFirstButton.onClick.AddListener(TaskOnClick);
        
    }

    void TaskOnClick()
    {
        totalDice = 0;
        rollButtonPress = true;
        StartCoroutine(dice1.GetComponent<Dicee>().Roll());
        StartCoroutine(dice2.GetComponent<Dicee>().Roll());
        totalDice = dice1.GetComponent<Dicee>().value + dice2.GetComponent<Dicee>().value;
    }

}
