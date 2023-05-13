using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{

    [SerializeField] private Rigidbody2D _playerRigidbody2D;

    private Vector2 _direction;

    private Vector2 _lastVelocity;

    [SerializeField] private PlayerGroundDetector _playerGroundDetector;

    [SerializeField] private PlatformerPlayerMovementSettings _platformerPlayerMovementSettings;

    //controls how high player jumps
    private float _jumpHeight;

    //controls how much force is added downwards when the player is falling
    private float _downGravity;

    private void Update()
    {
        _jumpHeight = _platformerPlayerMovementSettings.jumpHeight;
        _downGravity = _platformerPlayerMovementSettings.downGravity;

        if (Input.GetKeyDown("space"))            
        {
            if (_playerGroundDetector.isGrounded){
          
                _direction = new Vector2(_playerRigidbody2D.velocity.x, _jumpHeight);

                _playerRigidbody2D.velocity = _direction;
            }          
        }

        if (_playerRigidbody2D.velocity.y < _lastVelocity.y)
        {
            Vector2 _downVelocity = new Vector2(_playerRigidbody2D.velocity.x, _playerRigidbody2D.velocity.y - _downGravity);
            _playerRigidbody2D.velocity = _downVelocity;
        }

        //stores player velocity on current frame so that it can be checked on the next frame
        _lastVelocity = _playerRigidbody2D.velocity;

    }
}