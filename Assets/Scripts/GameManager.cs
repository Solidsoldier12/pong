using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject Ball;
    public GameObject Player1Paddle;
    public GameObject Player2Paddle;
    public GameObject Player1Goal;
    public GameObject Player2Goal;
    public GameObject Player1Text;
    public GameObject Player2Text;
    private int Player1Score;
    private int Player2Score;
    public void Player1Scored()
    {
        Player1Score++;
        Player1Text.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
        ResetPosition();
    }
    
    public void Player2Scored()
    {
        Player2Score++;
        Player2Text.GetComponent<TextMeshProUGUI>().text = Player2Score.ToString();
        ResetPosition();
    }
    public void ResetPosition()
    {
        Ball.GetComponent<Ball>().Reset();
        Player1Paddle.GetComponent<Paddle>().Reset();
        Player2Paddle.GetComponent<Paddle>().Reset();
    }
}
