using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rigidbody;
    public float speed = 10.0f;
    public GameObject Lose;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        Lose.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Lose.activeSelf)
        {
            Time.timeScale = 0;
        }
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rigidbody.velocity = transform.forward * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            rigidbody.velocity = -transform.forward * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rigidbody.transform.Rotate(0, -2, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rigidbody.transform.Rotate(0, 2, 0);
        }
    }

    void OnCollisionEnter(Collision RockCol)
    {
        Rock rock = RockCol.gameObject.GetComponent<Rock>();
        if (rock)
        {
            Destroy(RockCol.gameObject);
            Lose.SetActive(true); 
        }
    }

}
