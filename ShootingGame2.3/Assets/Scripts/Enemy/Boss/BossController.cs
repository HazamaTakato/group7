using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour
{

    public GameObject BlackEnemyBullet;
    public GameObject OrangeEnemyBullet;
    public GameObject PinkEnemyBullet;
    public float X_Speed;
    float orangeIntervalTime;
    float blackIntervalTime;
    float pinkIntervalTime;
    

    // Start is called before the first frame update
    void Start()
    {
        orangeIntervalTime = 0;
        blackIntervalTime = 0;
        pinkIntervalTime = 0;

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(X_Speed, 0, 0);
        if (transform.position.x > 2 || transform.position.x < -2)
        {
            X_Speed *= -1;
        }

        List<Quaternion> quat = new List<Quaternion>();
        for (int i = 0; i < 12; i++)
        {
            quat[i] = Quaternion.Euler(0, i * 30, 0);
        }

        blackIntervalTime += Time.deltaTime;

        if(blackIntervalTime >= 1.5f)
        {
            blackIntervalTime = 0.0f;
            for(int i = 0;i < 3; i++)
            {
                Quaternion q = quat[6 + i];
                Instantiate(BlackEnemyBullet, transform.position, q);
            }
        }

        pinkIntervalTime += Time.deltaTime;

        if(pinkIntervalTime >= 3.0f)
        {
            pinkIntervalTime = 0.0f;
            for(int i = 0;i < 6; i++)
            {
                Quaternion q = quat[4 + i];
                Instantiate(PinkEnemyBullet, transform.position, q);
            }
        }


        orangeIntervalTime += Time.deltaTime;

        if (orangeIntervalTime >= 5.0f)
        {
            orangeIntervalTime = 0.0f;
            for(int i = 0;i < 12; i++)
            {
                Quaternion q = quat[i];
                Instantiate(OrangeEnemyBullet, transform.position, q);
            }
        }
    }

}
