using System;
using System.Collections;
using System.Collections.Generic;
using GameFolders.Scripts.Concretes.Managers;
using TMPro;
using UnityEngine;

namespace GameFolders.Scripts.Concretes.UIs
{
    public class DisplayScore : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _scoreText;

        private void Start()
        {
            GameManager.Instance.ScoreChanged += HandleOnScoreChanged;
            HandleOnScoreChanged();
        }

        private void OnDisable()
        {
            GameManager.Instance.ScoreChanged -= HandleOnScoreChanged;
        }

        private void HandleOnScoreChanged(int score=0)
        {
            _scoreText.text = $"Score: {score}";
        }
    }
}

