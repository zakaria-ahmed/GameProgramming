using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusTime : MonoBehaviour
{
  public GameObject pickupEffect;
    
    public int maxSpeed;

    private Vector3 startPosition;

    void Start()
    {
    
        maxSpeed = 3;

        startPosition = transform.position;

    }

    private void Update()
    {
        MoveVertical();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            PickUp();
          
        }
    
    }

    void PickUp()
    {

        Instantiate(pickupEffect, transform.position, transform.rotation);
        Timer.currentTime += 10;
        Destroy(gameObject);
        Debug.Log("det virker");
    }

  
    void MoveVertical()
    {
        transform.position = new Vector3(transform.position.x, startPosition.y + Mathf.Sin(Time.time * maxSpeed), transform.position.z);

        if (transform.position.y > 1.0f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }
        else if (transform.position.y < -1.0f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        }
    }
}
