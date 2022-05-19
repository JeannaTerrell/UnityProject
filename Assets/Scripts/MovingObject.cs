using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction
{
    Horizontal,
    Vertical
}


public class MovingObject : MonoBehaviour
{
    public Direction Direction;
    public int Speed;
    public float Distance;
 

    private Rigidbody2D _rb;
    private float _startingPositionY;
    private float _startingPositionX;
    private float _target;
    private int _startingSpeed;

    //Called by the game engine at the start of the game
    private void Awake()
    {
        //RigidBody2D is the class provided by the Unity engine to handle physics on game objects
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

        _startingSpeed = Speed;

        Pause(true);
        Pause(false);

    }

    //Called up to 60 times per second by the game engine
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

    //When direction is set to vertical the moving object moves upward until the target distance is reached then reverses back to starting position
    private void Vertical()
    {
        //transform.postion represents the current location of an object in world space
        var position = transform.position;

        if (position.y > _target && Speed > 0)
        {
            OnReachedTarget();
            Speed = -Speed;
        }
        else if (position.y < _startingPositionY)
        {
           Speed = -Speed;
        }
        _rb.velocity = new Vector2(0, Speed * Time.deltaTime);
    }

    //When direction is set to horizontal, the moving object moves to one side until the target distance is reached then reverses back to the starting position
    private void Horizontal()
    {
        var position = transform.position;

        if (position.x > _target && Speed > 0)
        {
            OnReachedTarget();
            Speed = -Speed;
        }
        else if (position.x < _startingPositionX)
        {
            Speed = -Speed;
        }
        _rb.velocity = new Vector2(Speed * Time.deltaTime, 0);
    }

    
    public void Pause(bool pause)
    {
        if (pause)
        {
            Speed = 0;
        }
        else
        {
            Speed = _startingSpeed;
        }
    }

    public void changeSpeed(int newSpeed)
    {
        _startingSpeed = newSpeed;
        Speed = newSpeed;
    }

    protected virtual void OnReachedTarget()
    {
        //Debug.Log("Reached destination");
    }
}
