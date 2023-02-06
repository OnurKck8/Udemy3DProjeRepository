using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyProject1.Inputs
{
    public class DefaultInput
    {
        private DefaultAction _input;
        public bool _isForceUp { get; private set; }

        public DefaultInput()
        {
            _input = new DefaultAction();
            _input.Rocket.ForceUp.performed += context => _isForceUp = context.ReadValueAsButton();

            _input.Enable();
        }

       
    }
}

