using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    // [SerializeField] private GameObject startButton;

    public MoveBall moveBall;

    private void Start()
    {
        moveBall.isMoving = false;
    }

    private void Update()
    {
        SpawnObject();
    }

    public void SpawnObject()
    {
        if(moveBall.isMoving == false)
        {
            Instantiate(ball, Vector2.zero, Quaternion.identity);
            moveBall.isMoving = true;
            Debug.Log("ping");
        }
    }
}
