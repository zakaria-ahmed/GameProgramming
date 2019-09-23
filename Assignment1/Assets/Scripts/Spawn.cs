using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
  public Transform SpawnPoint;
  public Rigidbody RigidbodyPreFab;

  public void OnTriggerEnter()
  {
    Rigidbody rgPreFab;

    rgPreFab = Instantiate(RigidbodyPreFab, SpawnPoint.position, SpawnPoint.rotation) as Rigidbody;
  }

}
