using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomingEnemy : MonoBehaviour
{
    public GameObject EnemyBullet;
    public float Z_Speed = 0.7f;
    float intervalTime;

    // Use this for initialization
    void Start()
    {
        intervalTime = 0;
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(0, 0, -1 * Z_Speed);

        Quaternion quat = Quaternion.Euler(0, 180, 0);

        intervalTime += Time.deltaTime;
        if (intervalTime >= 20.0f)
        {
            intervalTime = 0.0f;
            Instantiate(EnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "PlayerBullet")
        {
            Destroy(this.gameObject);
        }
    }
}
