using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function : MonoBehaviour
{
    int health = 100;
    int attackPower = 25;
    bool shieldOn = false;
    int shield = 50; 
    void Start()
    {
        Debug.Log("Health: " + health);
    
    }

    public void Attack() {
        int damageToInflict = GetAttackDamage(shieldOn, shield, attackPower);
        health = health - damageToInflict;
        Debug.Log("Health Remains: " + health);
    }

    public void Heals()
    {
        int amount = GetRandomNumber();
        health += amount;
        Debug.Log("Health Remains: " + health);
    }

    private int GetAttackDamage(bool isShieldOn, int isShieldAmount, int AttackAmount)
    {
        int damage = 0;
        if (isShieldOn)
        {
            damage = AttackAmount - (int)((float)isShieldAmount * 0.10f);
        }
        else
        {
            damage = AttackAmount;
        }

        return damage;
    }

    private int GetRandomNumber()
    {
        return Random.Range(2, 10);
    }
}
