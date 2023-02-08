using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyProject1.Abstracts.Utilities
{
    public abstract class SingletonThisObject<T>: MonoBehaviour
    {
        public static T Instance { get; private set; } //tek olmasý için


        protected void SingletonThisGameObject(T entity)
        {
            if (Instance == null)
            {
                Instance = entity;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }

        }
    }
}

