using System.Collections;
using UnityEngine;

public class Dice : MonoBehaviour
{
   [SerializeField] private Sprite[] dieFace;

   public int value;
   public GameObject player1;
  

   public IEnumerator Roll()
   {
       for (int i = 0; i < 20; i++)
       {
           int num = Random.Range(0, 6) + 1;
           GetComponent<SpriteRenderer>().sprite = dieFace[num - 1];
           value = num;
           yield return new WaitForSeconds(15f);
       }
       //StartCoutine(Player1.GetComponent<Player>().followWaypoints());
       player1.GetComponent<Player>().followWaypoints();
   }
  
}
