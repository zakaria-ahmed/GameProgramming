using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingSystem : MonoBehaviour
{
    public Rigidbody projectile;
    public Transform Spawnpoint;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody clone;
            clone = (Rigidbody)Instantiate(projectile, Spawnpoint.position, projectile.rotation);

            clone.velocity = Spawnpoint.TransformDirection(Vector3.forward * 20);
        }

    }
}
