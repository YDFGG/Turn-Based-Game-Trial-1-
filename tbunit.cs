using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tbunit : MonoBehaviour
{
    public string unitName;

    public int damage;

    public int maxHP;
    public int currentHP;

    public EnemyHealthDisplay eHealth;
    public HealthDisplay pHealth;

    public bool TakeDamage(int dmg)
    {
        currentHP -= dmg;

        if(currentHP <= 0 )
            return true;

        else
            return false;
    }

    public void Heal(int amount)
    {
        currentHP += amount;
        if(currentHP > maxHP)
        {
            currentHP = maxHP;
        }
    }
}
