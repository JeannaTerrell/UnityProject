using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction
{
    Horizontal,
    Vertical
}


public class PlatformMovement : MonoBehaviour
{
    public Direction Direction;
    public int Speed;
    public float Distance;
 

    private Rigidbody2D _rb;
    private float _startingPositionY;
    private float _startingPositionX;
    private float _target;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _startingPositionY = transform.position.y;
        _startingPositionX = transform.position.x;

        if(Direction == Direction.Vertical)
        {
            _target = _startingPositionY + Distance;
        }
        else if(Direction == Direction.Horizontal)
        {
            _target = _startingPositionX + Distance;
        }

    }

    void FixedUpdate()
    {
        if (Direction == Direction.Vertical)
        {
            Vertical();
        }
        else if (Direction == Direction.Horizontal)
        {
            Horizontal();
        }
    }

    private void Vertical()
    {
        var position = transform.position;

        if (position.y > _target && Speed > 0)
        {
            Speed = -Speed;
        }
        else if (position.y < _startingPositionY)
        {
           Speed = -Speed;
        }
        _rb.velocity = new Vector2(0, Speed * Time.deltaTime);
    }

    private void Horizontal()
    {
        var position = transform.position;

        if (position.x > _target && Speed > 0)
        {
            Speed = -Speed;
        }
        else if (position.x < _startingPositionX)
        {
            Speed = -Speed;
        }
        _rb.velocity = new Vector2(Speed * Time.deltaTime, 0);
    }
}
