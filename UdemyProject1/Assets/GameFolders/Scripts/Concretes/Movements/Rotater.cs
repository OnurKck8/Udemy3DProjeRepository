using System.Collections;
using System.Collections.Generic;
using UdemyProject1.Controllers;
using UnityEngine;

namespace UdemyProjet1.Movements
{
    public class Rotater
    {
        Rigidbody _rigidbody;
        PlayerController _playercontroller;

        public Rotater(PlayerController playerController)
        {
            _playercontroller = playerController;
            _rigidbody = playerController.GetComponent<Rigidbody>();
        }

        public void FixedTick(float direction)
        {
            if(direction==0)
            {
                if (_rigidbody.freezeRotation) _rigidbody.freezeRotation = false;
                return;

                if (!_rigidbody.freezeRotation) _rigidbody.freezeRotation = true;

                _playercontroller.transform.Rotate(Vector3.forward * Time.deltaTime * direction * _playercontroller.TurnSpeed);
            }


        }

    }
}

