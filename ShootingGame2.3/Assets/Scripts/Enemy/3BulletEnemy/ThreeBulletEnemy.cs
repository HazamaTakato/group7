using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeBulletEnemy : MonoBehaviour
{
    public GameObject EnemyBullet;
    public float Y_Speed;
    public float X_Speed;
    float intervalTime;
    public float startZSpeed;
    public float startXSpeed;
    public float startYSpeed;

    public Vector3 endPos;
    bool mode;
    Rigidbody rb;
    public string pos;

    // Use this for initialization
    void Start()
    {
        intervalTime = 0;
        mode = false;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        MoveMode();

        Quaternion quat = Quaternion.Euler(0, 180, 0);
        Quaternion quat2 = Quaternion.Euler(0, 210, 0);
        Quaternion quat3 = Quaternion.Euler(0, 150, 0);

        intervalTime += Time.deltaTime;
        if (intervalTime >= 2.0f)
        {
            intervalTime = 0.0f;
            Instantiate(EnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat);
            Instantiate(EnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat2);
            Instantiate(EnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat3);
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
            else if (pos == "Left")
            {
                if (transform.position.x <= endPos.x)
                {
                    rb.velocity = new Vector3(5f, 0,0);
                }
                else
                {
                    mode = true;
                }

            }
            else if (pos == "Up")
            {
                if (transform.position.y >= endPos.y)
                {
                    rb.velocity = new Vector3(0, -5f, 0);
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
            if (transform.position.y > 3 || transform.position.y < -3)
            {
                Y_Speed *= -1;
            }
        }
    }
}

