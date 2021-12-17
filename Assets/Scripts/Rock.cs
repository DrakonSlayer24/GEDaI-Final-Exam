using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    Rigidbody rock;
    public float RockSpeed;
    public float StartX;
    public float EndX;
    private bool Count = true;
    // Start is called before the first frame update
    void Start()
    {
        rock = GetComponent<Rigidbody>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (Count)
            rock.AddForce(Vector3.left * RockSpeed);

        if (!Count)
            rock.AddForce(Vector3.right * RockSpeed);

        if (rock.position.x < StartX)
            Count = false;
        if (rock.position.x > EndX)
            Count = true;
    }
}
