using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invork : MonoBehaviour
{
    public GameObject target;


    void Start()
    {

        InvokeRepeating("SpawnObject", 2, 5);

    }

    void SpawnObject()
    {
        float x = Random.Range(-200.0f, 200.0f);
        float z = Random.Range(-200.0f, 200.0f);
        float Y = Random.Range(0.0f, 200.0f);
        Instantiate(target, new Vector3(x, Y, z), Quaternion.identity);
    }
}
