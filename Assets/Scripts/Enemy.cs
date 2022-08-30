using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Vector3 moveDirection;
    public float moveDistance;

    private Vector3 _startPos;
    private bool _movingToStart;

    private void Start()
    {
        _startPos = transform.position;
    }

    private void Update()
    {
        if (_movingToStart)
        {
            transform.position = Vector3.MoveTowards(transform.position, _startPos, speed * Time.deltaTime);

            if (transform.position == _startPos)
            {
                _movingToStart = false;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, _startPos + (moveDirection * moveDistance), speed * Time.deltaTime);

            if (transform.position == _startPos + (moveDirection * moveDistance))
            {
                _movingToStart = true;
            }
        }
    }
}
