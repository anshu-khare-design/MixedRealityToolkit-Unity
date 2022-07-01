using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerascript1 : MonoBehaviour
{
    // Start is called before the first frame update
    public float speedH = 2.0f;
    public float speedV = 2.0f;

    public float yaw = 0.0f;
    public float pitch = 0.0f;

    //private Rigidbody rb;

    public float speed = 0.005f;

    //public AudioSource audioData;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("w"))
        {
            //rb.velocity = (Vector3.forward * speed);
            Vector3 temp = new Vector3(0.001f, 0, 0);
            transform.position += (Vector3.forward * speed);
         //   audioData.Play();

        }
        else if (Input.GetKey("s"))
        {
            Vector3 temp = new Vector3(-0.001f, 0, 0);
            transform.position += (Vector3.back * speed); ;
          //  audioData.Play();

        }
        else if (Input.GetKey("a"))
        {
            Vector3 temp = new Vector3(0f, 0, 0.001f);
            transform.position += (Vector3.left * speed); ;
         //   audioData.Play();

        }
        else if (Input.GetKey("d"))
        {
            Vector3 temp = new Vector3(0f, 0, -0.001f);
            transform.position += Vector3.right * speed;
           // audioData.Play();

        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position += Vector3.up * speed;
            // this.gameObject.GetComponent<on_collision>().isGrounded = false;
        }

        // transform.position = 

        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        //audioData.Pause();
    }
}
