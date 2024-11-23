using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GoalOne : MonoBehaviour
{
    public int playerTwoScore = 0;
    [Space]
    [SerializeField] private Text playerTwoScoreText;
    [Space]
    public GameObject restartButton;
    [Space]
    [SerializeField] private TextMeshProUGUI endText;

    public MoveBall moveBall;

    GameObject ball;

    private void Update()
    {
        ball = GameObject.Find("Ball(Clone)");

        if(playerTwoScore >= 7)
        {
           moveBall.isMoving = true;
           restartButton.SetActive(true);
            endText.text = "Player two won!";
           // Debug.Log("Player One has won!");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            playerTwoScore++;
            playerTwoScoreText.text = playerTwoScore.ToString();
            moveBall.isMoving = false;
            Destroy(ball);
            // Debug.Log($"Player Two Score: {playerTwoScore}");
        }
    }
}
