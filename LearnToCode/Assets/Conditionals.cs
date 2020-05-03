using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
    int p1_tower = 2;
    int p2_tower = 2;

    bool p1_destroyed = false;
    bool p2_destroyed = false;
    int timer = 100;
    // Start is called before the first frame update
    void Start()
    {
        if (p1_destroyed || p2_destroyed)
        {
            if (p1_destroyed)
            {
                Debug.Log("Player 1 Wins!");
            }
            else if (p2_destroyed)
            {
                Debug.Log("Player 2 Wins!");
            }
        }
        else if (timer == 0)
        {
            if (p1_tower < p2_tower)
            {
                Debug.Log("Player 2 Wins!");
            }
            else if (p2_tower < p1_tower)
            {
                Debug.Log("Player 2 Wins!");
            }
            else
            {
                Debug.Log("Draw");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
