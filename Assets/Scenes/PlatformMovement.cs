using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public int Speed;
    public float Height;

    private Rigidbody2D _rb;
    private float _startingPositionY;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _startingPositionY = transform.position.y;

    }

    void FixedUpdate()
    {
        var position = transform.position;

        if (position.y > Height && Speed > 0)
        {
            Speed = -Speed;
        }
        else if(position.y < _startingPositionY)
        {
            Speed = -Speed;
        }
        _rb.velocity = new Vector2(0, Speed * Time.deltaTime);

        //var position = transform.position;

        //Debug.Log(position.y);
    }
}
