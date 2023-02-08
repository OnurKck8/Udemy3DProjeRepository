using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UdemyProject1.Abstracts.Utilities;

namespace UdemyProject1.Managers
{
    public class GameManager : SingletonThisObject<GameManager>
    {
        public event System.Action OnGameOver;
        public event System.Action OnMissionSucced;

        private void Awake()
        {
            SingletonThisGameObject(this);
        }

        public void GameOver()
        {
            OnGameOver?.Invoke();

            /*
            if(OnGameOver!=null)
            {
                GameOver();
            }
            */
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
            SoundManager.Instance.StopSound(1);
            yield return SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + levelIndex);//0 ise restart 1 ise bir sonraki level
            SoundManager.Instance.PlaySound(2);
        }
         
        public void LoadMenuScene()
        {
            StartCoroutine(LoadMenuSceneAsync());
        }
        private IEnumerator LoadMenuSceneAsync()
        {
            SoundManager.Instance.StopSound(2);
            yield return SceneManager.LoadSceneAsync("Menu");
            SoundManager.Instance.PlaySound(1);
        }
       

        /*
        public void Exit()
        {
            Application.Quit();
        }
        */
    }
}
