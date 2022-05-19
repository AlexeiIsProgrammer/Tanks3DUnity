using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    // Start is called before the first frame update\
    public float maxHealth = 100;
    private float minHealth = 0;

    private float currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public bool Damage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= minHealth)
        {
            print("Вы проиграли");
            return false;
        }
        return true;
    }

}
