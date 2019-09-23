using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Powerup : MonoBehaviour
{
    public GameObject pickupEffect;
    public float score = 0;
 
    public AudioClip sound;

    private AudioSource source { get { return GetComponent<AudioSource>(); } }

    public int maxSpeed;

    private Vector3 startPosition;

    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        source.clip = sound;

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
       
        source.PlayOneShot(sound);
    }

    void PickUp()
    {

        Instantiate(pickupEffect, transform.position, transform.rotation);
        ScoreCounter.scoreValue += 1;
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
