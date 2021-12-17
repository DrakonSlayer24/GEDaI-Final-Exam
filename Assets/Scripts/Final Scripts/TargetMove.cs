using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMove : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject Bullet = ObjectPool.SharedInstance.GetPooledObject();
            if (Bullet != null)
            {
                Bullet.transform.position = this.transform.position + this.transform.forward;
                Bullet.SetActive(true);
            }
        }
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = -transform.forward * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = transform.forward * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = -transform.right * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = transform.right * speed;
        }
    }

}
