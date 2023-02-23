using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameFolders.Scripts.Managers
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }

        private void Awake()
        {
            SingletonPattern();
        }

        private void SingletonPattern()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }

        public void RestartGame()
        {
            StartCoroutine(RestartGameAsync());
        }

        private IEnumerator RestartGameAsync()
        {
            yield return SceneManager.LoadSceneAsync("Game");
        }
    }
}

