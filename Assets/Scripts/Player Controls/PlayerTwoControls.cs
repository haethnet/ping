using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerTwoControls : MonoBehaviour
{
    public float speed;
    private PlayerTwoInputActions playerTwoControls;

    Rigidbody2D rb;
    Vector2 moveDirection = Vector2.zero;

    InputAction move;

    private void Awake()
    {
        // creating an instance of the script
        playerTwoControls = new PlayerTwoInputActions();
    }

    private void OnEnable()
    {
        // enabling move controls
        move = playerTwoControls.Player.Move;
        move.Enable();
    }

    private void OnDisable()
    {
        // disabling move controls
        move.Disable();
    }

    void Start()
    {
        // grabbing Rigidbody2D
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // creating a boundry the player can not pass so they dont bounce off the bottom and top collider
        if (transform.position.y < -4)
        {
            transform.position = new Vector2(transform.position.x, -4);
        }

        if (transform.position.y > 4)
        {
            transform.position = new Vector2(transform.position.x, 4);
        }
    }

    private void FixedUpdate()
    {
        // grabbing the value we wish to read, in this case a Vector2 to move
        moveDirection = move.ReadValue<Vector2>();

        // move the player with rb.velocity
        rb.velocity = speed * Time.deltaTime * moveDirection;
    }
}
