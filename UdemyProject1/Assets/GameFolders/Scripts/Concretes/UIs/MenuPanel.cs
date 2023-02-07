using System.Collections;
using System.Collections.Generic;
using UdemyProject1.Managers;
using UnityEngine;

namespace UdemyProejct1.UIs
{
    public class MenuPanel : MonoBehaviour
    {
        public void StartClick()
        {
            GameManager.Instance.LoadLevelScene(1);
        }
        public void ExitClick()
        {
            GameManager.Instance.Exit();
        }
    }
}