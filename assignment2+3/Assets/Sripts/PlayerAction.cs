using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerAction : MonoBehaviour
{

    public float score = 0;
    public Text scoreText;
    private bool onOff = true;
    public GameObject ring;
    public GameObject ring2;
    public GameObject ring3;
    public GameObject ring4;
    private Vector3 offset = new Vector3(0, 10, -30);
    public AudioClip sound;
    private AudioSource source { get { return GetComponent<AudioSource>(); } }
    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        source.clip = sound;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < ring.transform.position.y + 6 && transform.position.y > ring.transform.position.y - 6 && transform.position.x < ring.transform.position.x + 6 && transform.position.x > ring.transform.position.x - 6 && transform.position.z < ring.transform.position.z + 6 && transform.position.z > ring.transform.position.z - 6)
        {
            source.PlayOneShot(sound);
            if (onOff)
            {
                score++;
                scoreText.text = score.ToString();
                onOff = false;
            }
        }
     
        if (transform.position.y < ring2.transform.position.y + 6 && transform.position.y > ring2.transform.position.y - 6 && transform.position.x < ring2.transform.position.x + 6 && transform.position.x > ring2.transform.position.x - 6 && transform.position.z < ring2.transform.position.z + 6 && transform.position.z > ring2.transform.position.z - 6)
        {
            source.PlayOneShot(sound);
            
            if (onOff == false)
            {
                score++;
                scoreText.text = score.ToString();
                onOff = true;
            }
        }
       
        if (transform.position.y < ring3.transform.position.y + 6 && transform.position.y > ring3.transform.position.y - 6 && transform.position.x < ring3.transform.position.x + 6 && transform.position.x > ring3.transform.position.x - 6 && transform.position.z < ring3.transform.position.z + 6 && transform.position.z > ring3.transform.position.z - 6)
        {
            source.PlayOneShot(sound);
            if (onOff)
            {
                score++;
                scoreText.text = score.ToString();
                onOff = false;
            }
        }
        
        if (transform.position.y < ring4.transform.position.y + 6 && transform.position.y > ring4.transform.position.y - 6 && transform.position.x < ring4.transform.position.x + 6 && transform.position.x > ring4.transform.position.x - 6 && transform.position.z < ring4.transform.position.z + 6 && transform.position.z > ring4.transform.position.z - 6)
        {
            source.PlayOneShot(sound);
            if (onOff == false)
            {
                score++;
                scoreText.text = score.ToString();
                onOff = true;
            }
        }
    }



}
