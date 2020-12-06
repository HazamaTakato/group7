using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotEnemyBullet : MonoBehaviour
{
    float bulletSpeed = 0.5f;

    // Use this for initialization
    void Start()
    {
        Destroy(this.gameObject, 2);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, bulletSpeed);

        if (Time.timeScale == 0f)
        {
            Destroy(gameObject);
        }

    }
}
