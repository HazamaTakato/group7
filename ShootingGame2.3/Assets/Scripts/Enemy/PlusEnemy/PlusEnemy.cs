using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusEnemy : MonoBehaviour
{
    public GameObject EnemyBullet;
    public GameObject bulletNormal;
    float intervalTime;
    float interval;


    // Start is called before the first frame update
    void Start()
    {
        intervalTime = 0;
        interval = 0;
    }

    // Update is called once per frame
    void Update()
    {
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
            Instantiate(EnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat1);
            Instantiate(EnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat2);
            Instantiate(EnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat3);
            Instantiate(EnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat4);
            Instantiate(EnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat5);
            Instantiate(EnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat6);
            Instantiate(EnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat7);
            Instantiate(EnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat8);
            Instantiate(EnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat9);
            Instantiate(EnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat10);
            Instantiate(EnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat11);
            Instantiate(EnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat12);
            Instantiate(EnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat13);
            Instantiate(EnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat14);
            Instantiate(EnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat15);
            Instantiate(EnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat16);
            Instantiate(EnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat17);
        }

        interval += Time.deltaTime;
        if (interval > 1f)
        {
            interval = 0.0f;
            Instantiate(bulletNormal, transform.position, transform.rotation);
        }

    }

}
