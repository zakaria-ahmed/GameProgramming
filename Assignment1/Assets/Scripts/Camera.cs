﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
  public GameObject player;

 private Vector3 offset;
  // Start is called before the first frame update
  void Start()
    {
   offset = transform.position - player.transform.position;
    print("hello world");
    }

    // Update is called once per frame
    void LateUpdate()
    {
     transform.position = player.transform.position + offset;
    // transform.position = player.transform.position;
   // transform.rotation = player.transform.rotation;
  }
}
