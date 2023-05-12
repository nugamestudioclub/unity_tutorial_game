using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    [SerializeField] private Rigidbody2D _playerRigidbody2D;

    [SerializeField] private PlayerMovementSettings _playerMovementSettings;

    private float moveSpeed;

    private Vector2 moveDirection = Vector2.zero;


    private void Update()
    {
        moveSpeed = _playerMovementSettings.moveSpeed;
        moveDirection = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, _playerRigidbody2D.velocity.y);
        _playerRigidbody2D.velocity = moveDirection;

    }


}