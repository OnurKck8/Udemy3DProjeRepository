using System;
using System.Collections;
using System.Collections.Generic;
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

        bool _isForceUp;
        float _leftright;

        public float TurnSpeed => _turnSpeed;
        public float Force => _force;

        private void Awake()
        {         
            _defaultInput = new DefaultInput();
            _mover = new Mover(this);
            _rotater = new Rotater(this);
        }

        //Input operations
        private void Update()
        {
            if (_defaultInput._isForceUp)
            {
                _isForceUp = true;
            }
            else
            {
                _isForceUp = false;
            }

            _leftright = _defaultInput._leftright;

        }

        //physics operations
        private void FixedUpdate()
        {
            
            if(_isForceUp)
            {
                _mover.FixedTick();
            }
            _rotater.FixedTick(_leftright);
        }
    }
}


