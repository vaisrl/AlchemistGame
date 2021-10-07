using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageText : MonoBehaviour
{
    public Text text;
    
    void Update()
    {
        text.text = GameController.singleton.damage.ToString();
    }
}
