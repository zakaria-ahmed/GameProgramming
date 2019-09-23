using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public GameObject pickupEffect;

    public int maxSpeed;

    public GameObject move;




    // Update is called once per frame
    void Update()
    {
        move.transform.Rotate(Vector3.up, maxSpeed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fire"))
        {

            PickUp();

        }

    }

    void PickUp()
    {

        Instantiate(pickupEffect, transform.position, transform.rotation);
        
        Destroy(gameObject);
        Debug.Log("det virker");
    }

}
