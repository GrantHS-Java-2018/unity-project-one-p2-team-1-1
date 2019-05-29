using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RollButton : MonoBehaviour
{
    public Boolean rollButteonPress = false;
    public Boolean pressRoll = false
    private int _button;
    public Button yourFirstButton;
    public GameObject dice1, dice2;
    public GameObject player1;

    public Button rollButton;
    public GameObject die1, die2;
    public GameObject player2;
    public int totalDice;

    public void Start()
    {
        //GetComponentInParent<Button>().AddListener(TaskOnClick);


        void Start()
        {
            yourFirstButton.onClick.AddListener(TaskOnClick);

            //totalDice = 0;

            StartCoroutine(die1.);

        }

        void TaskOnClick()
        {
            for (int i = 0; i < 10; i++)
            {
                dice1.GetComponent<Dice>().Roll();
                dice2.GetComponent<Dice>().Roll();
                yield return new WaitForSeconds(.10f);
            }

            totalDice = dice1.GetComponent<Dice>().value + dice2.GetComponent<Dice>().value;
            MovePlayer(totalDice);

        }
    }
}
