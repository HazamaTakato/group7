using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int speed;
    Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //rb.velocity = new Vector3(0, 0,speed);

        Destroy(gameObject, 1f);
    }

    void Update()
    {
        transform.Translate(0, 0, 3f);
        if (Time.timeScale == 0f)
        {
            Destroy(gameObject);
        }

    }

    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
