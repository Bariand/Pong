using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] bool isPlayer1Goal;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            GameObject.Find("GameController").GetComponent<GameController>().Invoke("ResetGame", 2);
            if (isPlayer1Goal) 
            {
                GameObject.Find("GameController").GetComponent<GameController>().Player2Scored();
            }
            else
            {
                GameObject.Find("GameController").GetComponent<GameController>().Player1Scored();
            }   
        }
    }
}
