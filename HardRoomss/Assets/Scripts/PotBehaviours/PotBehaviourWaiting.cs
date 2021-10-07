using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.PotBehaviours
{
    class PotBehaviourWaiting : IPotBehaviour
    {
        private readonly PotController _pot;
        private readonly Animator _anim;
        private readonly GameObject[] _spells;
        private readonly Vector3 _slotPosition;
        public PotBehaviourWaiting(PotController pot, Animator anim, GameObject[] spells, Vector3 slotPosition)
        {
            _pot = pot;
            _anim = anim;
            _spells = spells;
            _slotPosition = slotPosition;
        }
        public void Enter()
        {
            Debug.Log(message: "Enter Waiting behaviour");
            _anim.SetBool("SlotIsFull", true);
        }

        public void Exit()
        {
            Debug.Log(message: "Exit Waiting behaviour");
        }

        public void Update()
        {
            Debug.Log(message: "Update Waiting behaviour");
            if (_pot.slotIsFull == false)
            {
                _pot.SetBehaviourDefault();
            }
        }
    }
}
