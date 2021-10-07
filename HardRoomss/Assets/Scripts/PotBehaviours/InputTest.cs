using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{
    public PotController pot;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            pot.SetBehaviourDefault();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            pot.SetBehaviourWaiting();
        }
    }
}
