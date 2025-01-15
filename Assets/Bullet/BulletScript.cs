using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private float timeAlive = 0f;
    private float maxTimeAlive = 5f;


    private void Update()
    {
        timeAlive += Time.deltaTime;

        if(timeAlive >= maxTimeAlive)
        {
            DestroyMe();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            DestroyMe();
        }
    }

    private void DestroyMe()
    {
        Destroy(gameObject);
        Destroy(this);
    }
}
