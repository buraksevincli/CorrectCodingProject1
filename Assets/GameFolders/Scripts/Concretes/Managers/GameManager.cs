using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameFolders.Scripts.Concretes.Managers
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }

        public event Action SceneObjectReset;
        public event Action<int> ScoreChanged;

        private int score;

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

        public void StartGame()
        {
            score = 0;
            Time.timeScale = 1f;
            StartCoroutine(StartGameAsync());
        }

        public void IncreaseScore()
        {
            score++;
            ScoreChanged?.Invoke(score);
        }

        private IEnumerator StartGameAsync()
        {
            SceneObjectReset?.Invoke();
            yield return SceneManager.LoadSceneAsync("Game");
        }

        public void ReturnMenu()
        {
            StartCoroutine(ReturnMenuAsync());
        }

        private IEnumerator ReturnMenuAsync()
        {
            SceneObjectReset?.Invoke();
            yield return SceneManager.LoadSceneAsync("Menu");
        }

        public void ExitGame()
        {
            Application.Quit();
        }
    }
}

