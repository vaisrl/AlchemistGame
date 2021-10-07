using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public float speed =5f;
    public float damage =5f;

    public static GameController singleton { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        singleton = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void increaseSpeed()
    {
        speed++;
    }
    public void increaseDamage()
    {
        damage++;
    }
}
