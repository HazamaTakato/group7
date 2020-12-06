using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotEnemyController : MonoBehaviour
{
    public GameObject EnemyBullet;
    public float X_Speed;
    public float Y_Speed;
    float intervalTime;
    public float interval;
    Vector3 startPos;

    public Vector3 endPos;
    bool mode;
    Rigidbody rb;
    public string pos;
    public bool pattern;

    // Use this for initialization
    void Start()
    {
        intervalTime = 0;
        startPos = transform.position;
        mode = false;
        rb = GetComponent<Rigidbody>();

        if(pattern == true)
        {
            interval = 1.0f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        MoveMode();

        Quaternion quat = Quaternion.Euler(0, 180, 0);

        intervalTime += Time.deltaTime;
        if (intervalTime >= interval)
        {
            interval = 2.0f;
            intervalTime = 0.0f;
            Instantiate(EnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat);
        }
    }

    void FixedUpdate()
    {
    }


    void MoveMode()
    {
        if (mode == false)
        {
            if (pos == "Right")
            {
                if (transform.position.x >= endPos.x)
                {
                    rb.velocity = new Vector3(-5f, 0, 0);
                }
                else
                {
                    mode = true;
                }
            }
            else if(pos == "Left")
            {
                if (transform.position.x <= endPos.x)
                {
                    rb.velocity = new Vector3(5f, 0, 0);
                }
                else
                {
                    mode = true;
                }
            }
        }
        if (mode == true)
        {
            rb.velocity = new Vector3(0, 0, 0);
            transform.Translate(X_Speed, Y_Speed, 0);
            if (transform.position.x > 5.5 || transform.position.x < -5.5)
            {
                X_Speed *= -1;
            }
            if (transform.position.y > 3 || transform.position.y < -2)
            {
                Y_Speed *= -1;
            }
        }    
    }
}
