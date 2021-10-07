using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Assets.Scripts.PotBehaviours
{
    class PotBehaviourDefault : IPotBehaviour
    {
        private readonly PotController _pot;
        private readonly Animator _anim;
        private readonly GameObject[] _spells;
        private readonly Vector3 _slotPosition;
        private readonly Transform _spellSlot;
        public PotBehaviourDefault(PotController pot, Animator anim, GameObject [] spells, Vector3 slotPosition, Transform spellSlot)
        {
            _pot = pot;
            _anim = anim;
            _spells = spells;
            _slotPosition = slotPosition;
            _spellSlot = spellSlot;
        }

        public void Enter()
        {
            _pot.StartCoroutine(PooringPotion());
        }

        public void Exit()
        {
            Debug.Log(message: "Exit default behaviour");
        }

        public void Update()
        {
            Debug.Log(message: "Update default behaviour");
        }


        IEnumerator PooringPotion()
        {
            _anim.SetBool("SlotIsFull", false);
            yield return new WaitForSeconds(2f);            
            GameObject.Instantiate(_spells[Random.Range(0, 3)], _slotPosition, Quaternion.identity);
            _pot.slotIsFull = true;
            _pot.SetBehaviourWaiting();
            
        }

    }
}
