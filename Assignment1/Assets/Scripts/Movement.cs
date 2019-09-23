using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Movement : MonoBehaviour
{
  public AudioClip SoundClip;
  private AudioSource Source { get { return GetComponent<AudioSource>(); } }

  private Button button { get { return GetComponent<Button>(); } }

  private Rigidbody rigidbody;

  public float speed;




  // Start is called before the first frame update
  void Start()
  {

    gameObject.AddComponent<AudioSource>();
    Source.clip = SoundClip;
    Source.playOnAwake = false;
    rigidbody = GetComponent<Rigidbody>();
    button.onClick.AddListener(() => PlaySound());
  }

  // Update is called once per frame
  void FixedUpdate()
  {

  float horizontal = Input.GetAxis("Horizontal");
  float vertical = Input.GetAxis("Vertical");
    bool fKey = Input.GetKey(KeyCode.F);


    if (fKey)
    {
      print("respect");
    }

      Vector3 move = new Vector3(horizontal, 0.0f, vertical);

    rigidbody.AddForce(move * speed);

  }



  public void onClickBtn()
  {
    print("Hello from btn");
  }

  void PlaySound()
  {
    Source.PlayOneShot(SoundClip);
  }
}
