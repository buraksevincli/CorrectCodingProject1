using System;
using System.Collections;
using System.Collections.Generic;
using GameFolders.Scripts.Managers;
using UnityEngine;
using GameFolders.Scripts.Movements;

namespace GameFolders.Scripts.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        private Rigidbody2D _rigidbody2D;
        private Jump _jump;
        private PcInputController _pcInputController;
        
        private bool _isJumped;

        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
            _jump = GetComponent<Jump>();
            _pcInputController = new PcInputController();
        }

        private void FixedUpdate()
        {
            if (_isJumped)
            {
                _jump.JumpAction(_rigidbody2D);
                _isJumped = false;
            }
        }

        private void OnCollisionEnter2D(Collision2D col)
        {
            GameManager.Instance.RestartGame();
        }

        private void Update()
        {
            if (_pcInputController.LeftMouseClicked)
            {
                _isJumped = true;
            }
        }
    }
}

