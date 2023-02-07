using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UdemyProject1.Managers
{
    public class GameManager : MonoBehaviour
    {
        public event System.Action OnGameOver;
        public event System.Action OnMissionSucced;

        public static GameManager Instance { get;private set; } //tek olmas� i�in

        private void Awake()
        {

            SingletonThisGameObject();
          
        }

        private void SingletonThisGameObject()
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

        public void GameOver()
        {
            OnGameOver?.Invoke();

            //if(OnGameOver!=null)
            //{
            //    GameOver();
            //}
        }
        public void MissionSucced()
        {
            OnMissionSucced?.Invoke();
        }
        public void LoadLevelScene(int levelIndex=0)
        {
            StartCoroutine(LoadLevelSceneAsync(levelIndex));
        }
        private IEnumerator LoadLevelSceneAsync(int levelIndex)
        {
            yield return SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex+levelIndex);//0 ise restart 1 ise bir sonraki level
        }

        public void LoadMenu()
        {
            StartCoroutine(LoadMenuSceneAsync());
        }
        private IEnumerator LoadMenuSceneAsync()
        {
            yield return SceneManager.LoadSceneAsync("Menu");
        }

        public void Exit()
        {
            Application.Quit();
        }
    }
}
