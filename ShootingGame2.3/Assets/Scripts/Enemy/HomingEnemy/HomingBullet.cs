using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HomingBullet : MonoBehaviour
{
    Vector3 obj;
    public bool mode;
    Rigidbody rb;
    float distance;
    Vector3 endPos;

    void Start()
    {
        Destroy(this.gameObject, 3f);
        GameObject player = GameObject.Find("Player");
        obj = player.transform.position;
        mode = true;
        endPos = new Vector3(obj.x - transform.position.x, obj.y - transform.position.y, obj.z - transform.position.z);
    }

    void Update()
    {
        Vector3 pos = transform.position;
        if (pos.z <= obj.z)
        {
            mode = false;
        }
        Move();

    }
    void Move()
    {
        float speed = 30f;
        float step = Time.deltaTime * speed;

        if (mode == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, obj, step);
        }
        if (mode == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, endPos, step);
        }
    }
}

