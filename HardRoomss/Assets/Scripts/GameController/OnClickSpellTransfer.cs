using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickSpellTransfer : MonoBehaviour
{
    [SerializeField] private Transform spellSpawnPosition;
    PotController pot;

    private void Start()
    {
        pot = FindObjectOfType<PotController>();
    }

    private void OnMouseDown()
    {
        if (FindObjectOfType<ProjectileMovement>().canBeTransfered == true)
        {
            FindObjectOfType<ProjectileMovement>().transform.position = spellSpawnPosition.position;
            FindObjectOfType<ProjectileMovement>().speed = GameController.singleton.speed;
            pot.slotIsFull = false;
        }
    }
}
