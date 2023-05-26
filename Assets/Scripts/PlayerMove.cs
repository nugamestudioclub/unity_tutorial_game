using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    [SerializeField] private Rigidbody2D _playerRigidbody2D;

    [SerializeField] private PlayerMovementSettings _playerMovementSettings;

    private float _moveSpeed;

    private Vector2 _moveDirection = Vector2.zero;


    private void Update()
    {
        _moveSpeed = _playerMovementSettings.moveSpeed;
        _moveDirection = new Vector2(Input.GetAxis("Horizontal") * _moveSpeed, _playerRigidbody2D.velocity.y);
        _playerRigidbody2D.velocity = _moveDirection;

    }


}
