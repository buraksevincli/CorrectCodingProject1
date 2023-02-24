using System;
using System.Collections;
using System.Collections.Generic;
using GameFolders.Scripts.Concretes.Enums;
using UnityEngine;

namespace GameFolders.Scripts.Concretes.Movements
{
    public class Mover : MonoBehaviour
    {
        [SerializeField] private float moveSpeed;
        [SerializeField] private DirectionEnum _direction;
        
        private Rigidbody2D _rigidbody2D;

        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void OnEnable()
        {
            _rigidbody2D.velocity = SelectedDirection() * moveSpeed;
        }

        private Vector2 SelectedDirection()
        {
            Vector2 selectedDirection;

            if (_direction == DirectionEnum.Left)
            {
                selectedDirection = Vector2.left;
            }
            else
            {
                selectedDirection = Vector2.right;
            }

            return selectedDirection;
        }
    }
}

