using System.Collections;
using System.Collections.Generic;
using UdemyProject1.Managers;
using UnityEngine;

namespace UdemyProject1.Uis
{
    public class WinConditionPanel : MonoBehaviour
    {
      public void YesClick()
        {
            GameManager.Instance.LoadLevelScene(1);
        }
    }

}

