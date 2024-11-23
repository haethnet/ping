using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    [SerializeField] private float minX, maxX, minY, maxY;
    [SerializeField] private float speed;

    // the position at which the ball will move to
    private Vector3 targetPosition;
    private Rigidbody2D rb;

    public bool isMoving = false; 

    private void Start()
    {
        GenerateRandomPos();

        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(isMoving)
        {
            MoveToTargetPosition();
        }
    }

    private void GenerateRandomPos()
    {
        // create a random value
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        // create the random position
        targetPosition = new Vector3(randomX, randomY, 0);

        isMoving = true;
    }

    private void MoveToTargetPosition()
    {
        // create a direction for the ball to move too
        Vector2 direction = (targetPosition - transform.position).normalized;

        rb.velocity = direction * speed;

        // distance between the ball and target position
        if(Vector2.Distance(transform.position, targetPosition) < 0.1f)
        {
            isMoving = false;
        }
    }
}
