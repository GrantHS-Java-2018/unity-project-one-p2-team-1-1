using System.Collections;
using UnityEngine;

public class Dice : MonoBehaviour
{
    [SerializeField] private Sprite[] dieFace;
    public int value;
    public int dice1;
    public int dice2;
    public GameObject player1;
    public GameObject player2;
    public int total;
    //start is called before the first frame update

    public void Roll()
      {
          StartCoroutine(RollAnim());
      }


    private IEnumerator RollAnim()
    {
        for (int i = 0; i < 10; i++)
        {
            int num1 = Random.Range(0, 6) + 1;
            GetComponent<SpriteRenderer>().sprite = dieFace[num1 - 1];
            dice1 = num1;
            yield return new WaitForSeconds(15f);
           
            int num2 = Random.Range(0, 6) + 1;
            GetComponent<SpriteRenderer>().sprite = dieFace[num2 - 1];
            dice2 = num2;
            yield return new WaitForSeconds(5f);

            value = dice1 + dice2;
        }
        value = dice1 + dice2;

    }
    
    
}