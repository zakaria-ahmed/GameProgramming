using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOO : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    // Start is called before the first frame update
    public float speed = 5;
   

    void Start()
    {
        offset = player.transform.position - transform.position;
    }

    void LateUpdate()
    {
        // Look
        var newRotation = Quaternion.LookRotation(player.transform.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, speed * Time.deltaTime);

        // Move
        Vector3 newPosition = player.transform.position - player.transform.forward * offset.z - player.transform.up * offset.y;
        transform.position = Vector3.Slerp(transform.position, newPosition, Time.deltaTime * speed);
    }
}
