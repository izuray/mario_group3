using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demon : EntityMovement
{
    public Transform player;
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float chaseRange = 5f;
    public float fireRate = 1f;
    private float nextFire = 0f;
    private Vector3 moveDirection;
    private float lifeTime = 5f;


    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer < chaseRange)
        {
            ChasePlayer();
            if (Time.time > nextFire)
            {
                nextFire = Time.time + 1 / fireRate;
                Shoot();
            }
        }
    }

    void ChasePlayer()
    {
        moveDirection = (player.position - transform.position).normalized;
        transform.position += moveDirection * speed * Time.deltaTime;
    }

    void Shoot()
    {
        // Instantiate a new bullet at the firePoint position
        GameObject newBullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = newBullet.GetComponent<Rigidbody2D>();
        rb.velocity = -firePoint.right * speed;
        Destroy(newBullet, lifeTime);
    }
}
