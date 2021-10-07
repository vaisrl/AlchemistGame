using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeutralMonster : MonoBehaviour
{
    public float currentHealth;
    public HealthValue maxHealth;


    private void Start()
    {
        currentHealth = maxHealth.initHealth;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<ProjectileMovement>() != null)
        {
            Destroy(collision.gameObject);
            TakeDamage(GameController.singleton.damage);
        }
    }

    private void TakeDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0f)
        {
            Die();
        }
    }


    private void Die()
    {
        // тут анимации и партиклы... Потом надо будет сделать корутину
        Destroy(gameObject);
    }
}
