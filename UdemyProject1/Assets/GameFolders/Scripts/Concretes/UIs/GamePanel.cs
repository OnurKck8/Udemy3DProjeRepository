using System.Collections;
using System.Collections.Generic;
using UdemyProject1.Managers;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UdemyProejct1.Uis
{
    public class GamePanel : MonoBehaviour
    {

        public void YesClick()
        {
            GameManager.Instance.LoadLevelScene();
        }

        public void NoClick()
        {
            GameManager.Instance.LoadMenuScene();
        }


    }
}

