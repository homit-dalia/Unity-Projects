using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D rb;
    float xInput;
    float yInput;
    Vector2 newPosition;
    public float moveSpeedX, moveSpeedY, xPositionLimit, yPositionLimit;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {

    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    void MovePlayer()
    {

        xInput = Input.GetAxis("Horizontal"); //gives value b/w -1 & 1
        yInput = Input.GetAxis("Vertical");  //gives value b/w -1 & 1

        newPosition = transform.position;

        newPosition.x += xInput * moveSpeedX;
        newPosition.y += yInput * moveSpeedY;

        newPosition.x = Mathf.Clamp(newPosition.x, -xPositionLimit, xPositionLimit);
        newPosition.y = Mathf.Clamp(newPosition.y, -yPositionLimit, yPositionLimit);

        rb.MovePosition(newPosition);

    }
}
