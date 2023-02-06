using System;
using System.Collections;
using System.Collections.Generic;
using UdemyProject1.Inputs;
using UdemyProject1.Movements;
using UnityEngine;

namespace UdemyProject1.Controllers
{
    public class PlayerController : MonoBehaviour
    {

        DefaultInput _defaultInput;
        Mover _mover;

        bool _isForceUp;

        private void Awake()
        {         
            _defaultInput = new DefaultInput();
            _mover = new Mover(GetComponent<Rigidbody>());
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

        }

        //physics operations
        private void FixedUpdate()
        {
            
            if(_isForceUp)
            {
                _mover.FixedTick();
            }
        }
    }
}


