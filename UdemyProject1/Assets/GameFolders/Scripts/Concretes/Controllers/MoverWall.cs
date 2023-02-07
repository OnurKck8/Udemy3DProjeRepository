using System.Collections;
using System.Collections.Generic;
using UdemyProject1.Abstracts.Controllers;
using UnityEngine;

namespace UdemyProject1.Controllers
{
    public class MoverWall : WallController
    {
        [SerializeField] Vector3 _direction;
      //  [Range(0f,1f)] //sýnýr için
        [SerializeField] float _factor;
        [SerializeField] float _speed=1f;

        private const float FULL_CIRCLE=Mathf.PI*2f;//deðiþmeyen anlamýna gelir.

        Vector3 _startPos;

        private void Awake()
        {
            _startPos = transform.position;

        }

        private void Update()
        {
            float cycle = Time.time / _speed;
            float sinWave =Mathf.Sin( cycle * FULL_CIRCLE);

            _factor = Mathf.Sin(sinWave);
            Vector3 offset = _direction * _factor;
            transform.position = offset + _startPos;

          //  Debug.Log(Mathf.Sin(Time.time));//oyun baþlanýldýðýnda kullanýlan saat süresi
        }
    }
}
