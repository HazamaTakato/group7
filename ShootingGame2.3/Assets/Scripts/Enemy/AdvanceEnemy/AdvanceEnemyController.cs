using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvanceEnemyController : MonoBehaviour
{
    public float Z_Speed;
    public float X_Speed;

    public float startZSpeed;
    public float startXSpeed;
    public float startYSpeed;

    public float xMove;
    public float yMove;
    public float zMove;

    public Vector3 endPos;
    bool mode;
    Rigidbody rb;
    public string pos;
    Quaternion enemyRota;
    public float rotateZ;
    Vector3 vec;


    // Start is called before the first frame update
    void Start()
    {
        mode = false;
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        MoveMode();
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
                    rb.velocity = new Vector3(startXSpeed, startYSpeed, startZSpeed);
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
                    rb.velocity = new Vector3(startXSpeed, startYSpeed, startZSpeed);
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
                    rb.velocity = new Vector3(startXSpeed, startYSpeed, startZSpeed);
                }
                else
                {
                    mode = true;
                }
            }
        }
        if (mode == true)
        {
            if (X_Speed == 0 && Z_Speed == 0)
            {
                rb.velocity = new Vector3(0, 0, 0);
                return;
            }
            else
            {
                rb.velocity = new Vector3(0, 0, 0);
                vec = new Vector3(transform.position.x + X_Speed, transform.position.y, transform.position.z);
                rb.MovePosition(vec);
                //transform.Translate(X_Speed,0, 0);
                if (transform.position.x < 5.5f)
                {
                    X_Speed += -0.1f;
                }
                else if (transform.position.x < -5.5f)
                {
                    X_Speed += 0.1f;
                }
            }
        }
    }

}
