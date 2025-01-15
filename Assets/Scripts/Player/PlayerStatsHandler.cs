using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatsHandler : MonoBehaviour
{
    public event Action OnDie;
    private int healthPoints = 1;
    public int HealthPoints
    {
        get { return healthPoints; }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Meteor")
        {
            if (healthPoints <= 0)
            {
                OnDie();
            }
        }
    }
}
