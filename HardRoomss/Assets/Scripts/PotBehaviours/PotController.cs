using Assets.Scripts.PotBehaviours;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PotController : MonoBehaviour
{    
    private Dictionary<Type, IPotBehaviour> behavioursMap;
    private IPotBehaviour currentBehaviour;

    public bool slotIsFull = false;
    public GameObject[] spells;
    public Animator anim;
    public Vector3 slotPosition;
    public Transform spellSlot;
    

    private void Awake()
    {
        slotPosition = GameObject.Find("SpellSlot").transform.position;
        spellSlot = GameObject.Find("SpellSlot").transform;
    }


    private void Start()
    {
        InitBehaviours();
        SetBehaviourByDefault();
        
    }

    private void InitBehaviours()
    {
        this.behavioursMap = new Dictionary<Type, IPotBehaviour>();

        this.behavioursMap[typeof(PotBehaviourDefault)] = new PotBehaviourDefault(this, anim, spells, slotPosition, spellSlot);
        this.behavioursMap[typeof(PotBehaviourWaiting)] = new PotBehaviourWaiting(this, anim, spells, slotPosition);
    }

    private void SetBehavior(IPotBehaviour newBehaviour)
    {
        if (currentBehaviour != null)
        {
            currentBehaviour.Exit();
        }
        currentBehaviour = newBehaviour;
        currentBehaviour.Enter();
    }

    private IPotBehaviour GetBehaviour<T>() where T : IPotBehaviour
    {
        var type = typeof(T);
        return this.behavioursMap[type];
    } 

    private void SetBehaviourByDefault()
    {
        this.SetBehaviourDefault();
    }

    private void Update()
    {
        if (currentBehaviour != null)
        {
            currentBehaviour.Update();
        }
    }

    public void SetBehaviourWaiting()
    {
        var behaviour = this.GetBehaviour<PotBehaviourWaiting>();
        SetBehavior(behaviour);
    }

    public void SetBehaviourDefault()
    {
        var behaviour = this.GetBehaviour<PotBehaviourDefault>();
        SetBehavior(behaviour);
    }

}
