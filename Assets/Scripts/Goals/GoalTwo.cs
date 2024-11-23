using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GoalTwo : MonoBehaviour
{
    public int playerOneScore = 0;
    [Space]
    [SerializeField] private Text playerOneScoreText;
    [Space]
    [SerializeField] private TextMeshProUGUI endText;

    public GameObject restartButton;

    
    public MoveBall moveBall;
    GameObject ball;

    private void Update()
    {
        ball = GameObject.Find("Ball(Clone)");

        if(playerOneScore >= 7)
        {
            moveBall.isMoving = true;
            restartButton.SetActive(true);
            endText.text = "Player one won!";
            // Debug.Log("Player One has won!");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            playerOneScore++;
            playerOneScoreText.text = playerOneScore.ToString();
            moveBall.isMoving = false;
            Destroy(ball);
            // Debug.Log($"Player One Score: {playerOneScore}");
        }
    }
}
