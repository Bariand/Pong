using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private int player1Score;
    private int player2Score;
    private Vector3 ballStartingPosition;
    [SerializeField] public GameObject ball;
    [SerializeField] public GameObject leftPaddle;
    [SerializeField] public GameObject rightPaddle;
    [SerializeField] public GameObject leftGoal;
    [SerializeField] public GameObject rightGoal;
    [SerializeField] public GameObject player1ScoreBoard;
    [SerializeField] public GameObject player2ScoreBoard;
    
    void Start()
    {
        player1Score = 0;
        player2Score = 0;
        ballStartingPosition = ball.GetComponent<Transform>().position;
    }

    public void Player1Scored()
    {
        player1Score++;
        player1ScoreBoard.GetComponent<TextMeshProUGUI>().text = player1Score.ToString();
    }

    public void Player2Scored()
    {
        player2Score++;
        player2ScoreBoard.GetComponent<TextMeshProUGUI>().text = player2Score.ToString();
    }

    public void ResetGame() 
    {
        ball.GetComponent<Transform>().position = ballStartingPosition;
    }
}