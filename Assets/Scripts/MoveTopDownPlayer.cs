using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTopDownPlayer : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _topDownPlayerRigidbody2D;

    [SerializeField] private TopDownPlayerMovementSettings _topDownPlayerMovementSettings;

    private Vector2 _moveDirection = Vector2.zero;
    private float _moveSpeed;

    private void Update()
    {
        _moveSpeed = _topDownPlayerMovementSettings.moveSpeed;
        _moveDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }
    private void FixedUpdate()
    {
        _topDownPlayerRigidbody2D.velocity = _moveDirection * _moveSpeed;
    }
}
