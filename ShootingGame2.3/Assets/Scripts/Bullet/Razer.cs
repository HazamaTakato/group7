using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Razer : MonoBehaviour
{
    PlayerController PC;
    public int speed;
    Rigidbody rb;

    void Start()
    {
        PC = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        rb = GetComponent<Rigidbody>();
        rb.velocity = (((PC.GetMOP() - transform.position) - transform.forward).normalized * speed);
    }

    void Update()
    {
        if (transform.position.z > 100)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Enemy")
        {
            Destroy(c.gameObject);
            Destroy(gameObject);
        }
    }
}
