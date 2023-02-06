using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyProejct1.Movements
{
    public class Fuel : MonoBehaviour
    {

        [SerializeField] float _maxFuel=100f;
        [SerializeField] float _currentFuel;
        [SerializeField] ParticleSystem _particleSystem;

        public bool isEmpty => _currentFuel < 1f;

        private void Awake()
        {
            _currentFuel = _maxFuel;
        }

        public void FuelInCrease(float increase)
        {
            _currentFuel += increase;
            _currentFuel = Mathf.Min(_currentFuel, _maxFuel);

            if(_particleSystem.isPlaying)
            {
                _particleSystem.Stop();
            }
        }

        public void FuelDecrease(float decrease)
        {
            _currentFuel -= decrease;
            _currentFuel = Mathf.Max(_currentFuel,0f);

            if (_particleSystem.isStopped)
            {
                _particleSystem.Play();
            }
        }
    }
}

