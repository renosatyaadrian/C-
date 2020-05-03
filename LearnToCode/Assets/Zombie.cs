using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : Humanoid
{
    private int poisonDamage = 5;

    public override void Move()
    {
        base.Move();
        transform.Translate(Vector3.left * 3 * Time.deltaTime);
    }

    public int AcidPukeAttack()
    {
        return attackDamage + poisonDamage;
    }

}
