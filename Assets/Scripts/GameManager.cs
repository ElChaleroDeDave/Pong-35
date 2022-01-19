using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject ball;

    public GameObject player1;
    public GameObject player1Goal;

    public GameObject player2;
    public GameObject player2Goal;

    public int player1Score;
    public int player2Score;

    public Text player1Text;
    public Text player2Text;

    public bool IAGame;

    public int maxScore = 3;

    public void ChekVictory()
    {
        if (player1Score >= maxScore)
        {
            SceneManager.LoadScene("VictoryPlayer1");
        }
        if (player2Score >= maxScore)
        {
            SceneManager.LoadScene("VictoryPlayer2");
        }
    }

    public void Player1Scored()
    {
        player1Score++;
        player1Text.text = player1Score.ToString();
        ChekVictory();
        ResetPosition();

    } 
    
    public void Player2Scored()
    {
        player2Score++;
        player2Text.text = player2Score.ToString();
        ChekVictory();
        ResetPosition();

    }

    public void ResetPosition()
    {
        if (IAGame)
        {
            ball.GetComponent<Ball>().Reset();
            player1.GetComponent<Players>().Reset();
        }
        else
        {
            ball.GetComponent<Ball>().Reset();
            player1.GetComponent<Players>().Reset();
            player2.GetComponent<Players>().Reset();
        }
    }


}
