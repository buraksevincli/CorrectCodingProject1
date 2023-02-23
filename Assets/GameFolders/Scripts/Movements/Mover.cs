using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyNamespace
{
    public class Mover : MonoBehaviour
    {
        [SerializeField] private float moveSpeed;
        
        private Rigidbody2D _rigidbody2D;

        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {
            _rigidbody2D.velocity = Vector2.left * moveSpeed;
        }
    }
}

