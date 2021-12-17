using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour
{
    Rigidbody rigidbody;
    public GameObject Win;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        Win.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision WinCol)
    {
        WinCup win = WinCol.gameObject.GetComponent<WinCup>();
        if (win)
        {
            Destroy(WinCol.gameObject);
            Win.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
