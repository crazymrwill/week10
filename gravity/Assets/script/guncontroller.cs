using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guncontroller : MonoBehaviour
{
    public bool isFiring;

    public bulletcontroller bullet;
    public float bulletSpeed;

    public float timeBetweenShots;
    private float shotCounter;

    public Transform firePoint;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isFiring)
        {
            shotCounter -= Time.deltaTime;
            if(shotCounter <= 0)
            {
                shotCounter = timeBetweenShots;
                Instantiate(bullet, firePoint.position, firePoint.rotation);
            }
        }
    }
}
