using System;
using System.Collections;
using System.Collections.Generic;
using UdemyProject1.Managers;
using UnityEngine;

namespace UdemyProject1.Uis
{
    public class GameOverObject : MonoBehaviour
    {
        [SerializeField] GameObject _gameOverPanel;

        private void Awake()
        {
            if(_gameOverPanel.activeSelf)
            {
                _gameOverPanel.SetActive(false);
            }
        }

        private void OnEnable()
        {
            GameManager.Instance.OnGameOver += HandeleOnGameOver;
        }
        
        private void OnDisable()
        {
            GameManager.Instance.OnGameOver -= HandeleOnGameOver;
        }

        private void HandeleOnGameOver()
        {
            if(!_gameOverPanel.activeSelf)
            {
                _gameOverPanel.SetActive(true);
            }
        }
    }
}

   
