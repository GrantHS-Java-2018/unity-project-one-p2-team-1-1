﻿using System.Collections;
using UnityEngine;

public class Dice : MonoBehaviour
{
    [SerializeField] private Sprite[] dieFace;

    public int value;
    public GameObject player1;
    public GameObject player2;
    public int total;
    //start is called before the first frame update

    void Awake()
    {
        
    }


    public IEnumerator Roll()
    {
        for (int i = 0; i < 20; i++)
        {
            int num = Random.Range(0, 6) + 1;
            GetComponent<SpriteRenderer>().sprite = dieFace[num - 1];
            total = num;
            yield return new WaitForSeconds(15f);
        }
        
    }
    
}