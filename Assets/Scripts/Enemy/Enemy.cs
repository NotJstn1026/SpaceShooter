using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    public static Action<int> OnDestroyed;

    public int reward = 10;

    [SerializeField]
    private float speed = 3f;
    [SerializeField]
    private Vector2 direction = Vector3.down;


    private void Update()
    {
        if (transform != null)
        {
            transform.position += Vector3.down * speed * Time.deltaTime ;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            OnDestroyed?.Invoke(reward);
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Bullet"))
        {
            OnDestroyed?.Invoke(reward);
            Destroy(gameObject);
        }
    }
}