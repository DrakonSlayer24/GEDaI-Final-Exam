using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using System;

public class PlayerBoost : MonoBehaviour
{
    Rigidbody rigidbody;
    public float BoostDistance;
    public GameObject Lose;

    //dll addon
    [DllImport("GEDaIMidTerm")]
    private static extern bool Mode();

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        Lose.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision PUCol)
    {
        Boost PU = PUCol.gameObject.GetComponent<Boost>();
        if (PU)
        {
            Destroy(PUCol.gameObject);
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + BoostDistance);
            Lose.SetActive(Mode());
        }
    }
}
