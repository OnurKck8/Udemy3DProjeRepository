using System.Collections;
using System.Collections.Generic;
using UdemyProject1.Managers;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UdemyProject1.Uis
{
    public class MenuPanel : MonoBehaviour
    {
        public void StartClick()
        {
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
        }
        public void ExitClick()
        {
            Application.Quit();
        }
    }
}