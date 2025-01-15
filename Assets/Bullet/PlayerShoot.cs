using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    private GameObject bullet;

    private GameObject player;

    private float bulletSpeed = 5f;

    private float shootCooldown = 0.25f;
    private float shootTimer = 0f;

    private void Awake()
    {

        player = GameObject.FindWithTag("Player");
        bullet = Resources.Load<GameObject>("Bullet");
    }

    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Space) && shootTimer <= 0)
        {
            Shoot();
            shootTimer = shootCooldown;
        }
        else
        {
            shootTimer -= Time.deltaTime;
        }
    }


    private void Shoot()
    {
        GameObject bulletClone = Instantiate(bullet, player.transform.position + new Vector3(0, 2, 0), player.transform.rotation);
        bulletClone.GetComponent<Rigidbody2D>().velocity = Vector3.up * bulletSpeed;
        //bulletClone.GetComponent<Rigidbody>().AddForce(Vector2.up * 10, ForceMode.Impulse);
    }
}
