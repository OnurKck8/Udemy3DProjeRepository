using System;
using System.Collections;
using System.Collections.Generic;
using UdemyProejct1.Movements;
using UdemyProject1.Inputs;
using UdemyProject1.Movements;
using UdemyProjet1.Movements;
using UnityEngine;

namespace UdemyProject1.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float _turnSpeed = 10f;
        [SerializeField] float _force = 55f;

        DefaultInput _defaultInput;
        Mover _mover;
        Rotater _rotater;
        Fuel _fuel; 

        bool _canForceUp;
        float _leftright;

        public float TurnSpeed => _turnSpeed;
        public float Force => _force;

        private void Awake()
        {         
            _defaultInput = new DefaultInput();
            _mover = new Mover(this);
            _rotater = new Rotater(this);
            _fuel = GetComponent<Fuel>();
        }

        //Input operations
        private void Update()
        {
            if (_defaultInput._isForceUp && !_fuel.isEmpty)
            {
                _canForceUp = true;
            }
            else
            {
                _canForceUp = false;
                _fuel.FuelInCrease(0.01f);
            }

            _leftright = _defaultInput._leftright;

        }

        //physics operations
        private void FixedUpdate()
        {
            
            if(_canForceUp)
            {
                _mover.FixedTick();
                _fuel.FuelDecrease(0.2f);
            }
            _rotater.FixedTick(_leftright);
        }
    }
}


