using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidBoss : MonoBehaviour
{

    public GameObject plusEnemyBullet;
    public GameObject hormingEnemyBullet;
    public GameObject normalEnemyBullet;
    public float X_Speed;
    public float Z_Speed;
    public float Y_Speed;
    float intervalTime;

    float hormingInterval;

    float normalIntervalTime;
    float pinkIntervalTime;
    bool horming;

    bool mode;
    Rigidbody rb;
    public string pos;
    public Vector3 endPos;



    // Start is called before the first frame update
    void Start()
    {
        intervalTime = 0;
        horming = false;
        mode = false;
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        MoveMode();
        Quaternion quat1 = Quaternion.Euler(0, 160, 0);
        Quaternion quat2 = Quaternion.Euler(0, 165, 0);
        Quaternion quat3 = Quaternion.Euler(0, 170, 0);
        Quaternion quat4 = Quaternion.Euler(0, 175, 0);
        Quaternion quat5 = Quaternion.Euler(0, 180, 0);
        Quaternion quat6 = Quaternion.Euler(0, 185, 0);
        Quaternion quat7 = Quaternion.Euler(0, 190, 0);
        Quaternion quat8 = Quaternion.Euler(0, 195, 0);
        Quaternion quat9 = Quaternion.Euler(0, 200, 0);
        Quaternion quat10 = Quaternion.Euler(20, 180, 0);
        Quaternion quat11 = Quaternion.Euler(15, 180, 0);
        Quaternion quat12 = Quaternion.Euler(10, 180, 0);
        Quaternion quat13 = Quaternion.Euler(5, 180, 0);
        Quaternion quat14 = Quaternion.Euler(-5, 180, 0);
        Quaternion quat15 = Quaternion.Euler(-10, 180, 0);
        Quaternion quat16 = Quaternion.Euler(-15, 180, 0);
        Quaternion quat17 = Quaternion.Euler(-20, 180, 0);



        intervalTime += Time.deltaTime;
        if (intervalTime >= 5.5f)
        {
            intervalTime = 0.0f;
            Instantiate(plusEnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat1);
            Instantiate(plusEnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat2);
            Instantiate(plusEnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat3);
            Instantiate(plusEnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat4);
            Instantiate(plusEnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat5);
            Instantiate(plusEnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat6);
            Instantiate(plusEnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat7);
            Instantiate(plusEnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat8);
            Instantiate(plusEnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat9);
            Instantiate(plusEnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat10);
            Instantiate(plusEnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat11);
            Instantiate(plusEnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat12);
            Instantiate(plusEnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat13);
            Instantiate(plusEnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat14);
            Instantiate(plusEnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat15);
            Instantiate(plusEnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat16);
            Instantiate(plusEnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat17);
            horming = false;
        }

        normalIntervalTime += Time.deltaTime;

        if (intervalTime >= 2f && horming == false)
        {
            Instantiate(hormingEnemyBullet, transform.position, transform.rotation);
            horming = true;
        }
        if(normalIntervalTime >= 1.5f)
        {
            normalIntervalTime = 0.0f;
            Instantiate(normalEnemyBullet, transform.position, Quaternion.Euler(0,180,0));
        }

    }
    void MoveMode()
    {
        if (mode == false)
        {
            if (pos == "Up")
            {
                if (transform.position.y >= endPos.y)
                {
                    rb.velocity = new Vector3(0, -3f, 0);
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
            transform.Translate(X_Speed, Y_Speed, Z_Speed);
            if (transform.position.x > 3 || transform.position.x < -3)
            {
                X_Speed *= -1;
                Z_Speed *= -1;
            }
            if (transform.position.y > 3 || transform.position.y < -1)
            {
                Y_Speed *= -1;

            }
        }
    }

}
