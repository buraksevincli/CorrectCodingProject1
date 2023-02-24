using System;
using System.Collections;
using System.Collections.Generic;
using GameFolders.Scripts.Concretes.Combats;
using UnityEngine;

namespace GameFolders.Scripts.Concretes.UIs
{
    public class GameCanvas : MonoBehaviour
    {
        private GameObject gameOverPanel;

        private void Awake()
        {
            gameOverPanel = transform.GetChild(1).gameObject;
        }

        private void Start()
        {
            Dead dead = FindObjectOfType<Dead>();

            dead.OnDead += HandleOnDead;
        }

        private void HandleOnDead()
        {
            gameOverPanel.SetActive(true);
        }
    }
}

