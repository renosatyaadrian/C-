using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string heroName = "Robber";
        string equipWeap = "Katana";
        string favFurnitre = "Electric Chair";

        int hp = 100;
        float shield = 80.5f;
        int laserDmg = 30;
        double actualDmgPercent = .05;

        int actualDamage = (int)(laserDmg * actualDmgPercent);
        hp -= actualDamage;

        shield = shield - (laserDmg - actualDamage);

        int example = 10 / 3;
        print("10/3"+example);
        int example2 = 10 % 3;
        print("10 % 3"+example2);


        Debug.Log(heroName);
        Debug.Log(equipWeap);
        Debug.Log(favFurnitre);
        Debug.Log("HP: " + hp);
        Debug.Log("Shield: " + shield);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
