using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    public Transform firePoint;
    public float rayLength = 100f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
            Debug.Log("Sparo");
        }
    }

    void Shoot()
    {
        Debug.DrawRay(firePoint.position, firePoint.forward * rayLength, Color.red, 100f);
        if (Physics.Raycast(firePoint.position, firePoint.forward, out RaycastHit hit, rayLength))
        {
            IHittable hittable = hit.collider.GetComponent<IHittable>();
            if (hittable != null)
            {
                Debug.Log("hittable");
                hittable.OnHit();
            }
        }
    }
}
