using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossEnemyController : MonoBehaviour
{
    public GameObject EnemyBullet;
    public float Z_speed ;
    float intervalTime;

    // Start is called before the first frame update
    void Start()
    {
        intervalTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, -1 * Z_speed);

        Quaternion quat1 = Quaternion.Euler(0, 180, 0);
        Quaternion quat2 = Quaternion.Euler(20, 210, 0);
        Quaternion quat3 = Quaternion.Euler(20, 150, 0);
        Quaternion quat4 = Quaternion.Euler(10, 165, 0);
        Quaternion quat5 = Quaternion.Euler(10, 195, 0);
        Quaternion quat6 = Quaternion.Euler(-20, 210, 0);
        Quaternion quat7 = Quaternion.Euler(-20, 150, 0);
        Quaternion quat8 = Quaternion.Euler(-10, 165, 0);
        Quaternion quat9 = Quaternion.Euler(-10, 195, 0);
        Quaternion quat10 = Quaternion.Euler(5f, 172.5f, 0);
        Quaternion quat11 = Quaternion.Euler(15f, 157.5f, 0);
        Quaternion quat12 = Quaternion.Euler(5f, 187.5f, 0);
        Quaternion quat13 = Quaternion.Euler(15f, 202.5f, 0);
        Quaternion quat14 = Quaternion.Euler(-5f, 172.5f, 0);
        Quaternion quat15 = Quaternion.Euler(-15f, 157.5f, 0);
        Quaternion quat16 = Quaternion.Euler(-5f, 187.5f, 0);
        Quaternion quat17 = Quaternion.Euler(-15f, 202.5f, 0);

        intervalTime += Time.deltaTime;
        if (intervalTime >= 5.0f)
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
    }

}
