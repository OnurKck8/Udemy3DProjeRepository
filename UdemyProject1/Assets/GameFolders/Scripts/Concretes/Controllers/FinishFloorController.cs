using System.Collections;
using System.Collections.Generic;
using UdemyProject1.Controllers;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UdemyProejct1.Controllers
{
    public class FinishFloorController : MonoBehaviour
    {
        [SerializeField] GameObject _finishfirework;
        [SerializeField] GameObject _finishlight;

        private void OnCollisionEnter(Collision other)
        {
            PlayerController player = other.collider.GetComponent<PlayerController>();

            if (player == null)
            {
                return;
            }
            if(other.GetContact(0).normal.y == -1)
            {
                _finishfirework.gameObject.SetActive(true);
                _finishlight.gameObject.SetActive(true);
            }
            else
            {
                //GameOver
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}
