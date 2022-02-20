using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    private float shootCooldown = 0;
    [SerializeField] private float bulletDelay;

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float bulletSpeed;
    [SerializeField] private Transform firePoint;

    private void FixedUpdate()
    {
        shootCooldown -= Time.deltaTime;
        shootCooldown = Mathf.Max(shootCooldown, 0);

        // Shooty pew pew
        if (Input.GetButton("Fire1") && shootCooldown <= 0)
        {
            Shoot();
            shootCooldown = bulletDelay; // Delay before next bullet
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * bulletSpeed, ForceMode.Impulse);
    }
}
