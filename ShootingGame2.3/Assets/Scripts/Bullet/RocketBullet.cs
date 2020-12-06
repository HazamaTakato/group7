using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketBullet : MonoBehaviour
{
    PlayerController PC;
    public int speed;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //MOP = GameObject.FindGameObjectWithTag("MousePosition");
        PC = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        rb = GetComponent<Rigidbody>();
        rb.velocity = (((PC.GetMOP() - transform.position - new Vector3(0, 0.5f, 0)) - transform.forward).normalized * speed);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > 25)
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
