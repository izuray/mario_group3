using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoBullet : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireRate = 0.5f;
    private float nextFireTime = 0f;
    private float _speed = 5f;
    private float lifeTime = 5f;
    void Start()
    {
       
    }
   
    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextFireTime)
        {
            nextFireTime = Time.time + 3f / fireRate;
            shoot();
        }
        void shoot()
        {
            GameObject newBullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = newBullet.GetComponent<Rigidbody2D>();
            rb.velocity = -firePoint.right * _speed;
            Destroy(newBullet, lifeTime);
        }
    }
}
