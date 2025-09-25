using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject projectilePrefab; // assign prefab in Inspector
    public Transform firePoint;         // empty GameObject where projectile spawns
    public float fireRate = 0.25f;

    private float nextFireTime = 0f;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + fireRate;
        }
    }

    void Shoot()
    {
        // Always fire facing right, so use Quaternion.identity (no rotation)
        Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
    }
}
