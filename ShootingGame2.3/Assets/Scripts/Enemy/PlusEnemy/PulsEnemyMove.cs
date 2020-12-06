using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulsEnemyMove : MonoBehaviour
{
    public float Z_Speed;
    public float X_Speed;

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
        Rotate();
    }
    void MoveMode()
    {
        if (mode == false)
        {
            if (pos == "Right")
            {
                if (transform.position.x >= endPos.x)
                {
                    rb.velocity = new Vector3(-10f, -10f, 0);
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
                    rb.velocity = new Vector3(10f, 10f, 0);
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
                    rb.velocity = new Vector3(0f, -2f, 0f);
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
            vec = new Vector3(transform.position.x + X_Speed, transform.position.y, transform.position.z);
            rb.MovePosition(vec);
            //transform.Translate(X_Speed,0, 0);
            if (transform.position.x < 5.5f)
            {
                X_Speed += -0.1f;
            }
            else if(transform.position.x < -5.5f)
            {
                X_Speed += 0.1f;
            }
        }
    }
    void Rotate()
    {
        enemyRota = Quaternion.Euler(0f, 0f, rotateZ);

        if(rotateZ > 360)
        {
            rotateZ = 0;
        }

        //if (X_Speed > 0)
        //{
            rotateZ += 1;
            transform.rotation = enemyRota;
            return;
        //}
        //else
        //{
        //    rotateZ += 1;
        //    transform.rotation = enemyRota;
        //    return;
        //}
    }
}
