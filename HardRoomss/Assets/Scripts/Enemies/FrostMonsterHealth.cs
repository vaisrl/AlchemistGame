using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrostMonsterHealth: MonoBehaviour
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
            if (collision.tag.Equals("FireBall"))
            {
                Destroy(collision.gameObject);
                TakeDamage(GameController.singleton.damage * 2);
                
            }
            else if (collision.tag.Equals("FrostBall"))
            {
                Destroy(collision.gameObject);
                addHealth(GameController.singleton.damage / 2);
            }
            else
            {
                Destroy(collision.gameObject);
                TakeDamage(GameController.singleton.damage);
            }
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

    private void addHealth(float value)
    {
        currentHealth += value;
    }

    private void Die()
    {
        // тут анимации и партиклы... Потом надо будет сделать корутину
        Destroy(gameObject);
    }
}
