using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GameFolders.Scripts.Concretes.Combats
{
    public class Dead : MonoBehaviour
    {
        private bool _isDead;

        public bool IsDead => _isDead;

        public event Action OnDead;

        private void OnCollisionEnter2D(Collision2D col)
        {
            _isDead = true;
            OnDead?.Invoke();
            Time.timeScale = 0f;
        }
    }

}
