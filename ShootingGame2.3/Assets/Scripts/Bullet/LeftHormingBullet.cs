using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftHormingBullet : MonoBehaviour
{
    PlayerController PC;
    public float speed = 200f;
    Rigidbody rb;
    public float angle = 0f;
    public float Vec = 150f;
    Vector3 shotPos = Vector3.zero;
    GameObject playerVec;
    EnemyManager enemy;
    Vector3 transPos;

    bool hit;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //rb.velocity = new Vector3(0, 0, 1 * speed);
        angle = angle * Mathf.PI / 180f;
        shotPos = transform.position;
        playerVec = GameObject.Find("Player");
        PC = playerVec.GetComponent<PlayerController>();
        enemy = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyManager>();

        hit = false;

        Destroy(gameObject, 2f);
    }

    void Update()
    {
        transPos = transform.position;
        float ang = angle * 180f / Mathf.PI;
        if (ang > -90f)
        {
            angle -= 20f * Mathf.PI / 180f;
            rb.velocity = new Vector3(-Vec * Mathf.Cos(angle) + PC.Velocity().x,
                PC.Velocity().y,
                -Vec * Mathf.Sin(angle) + PC.Velocity().z);
            return;
        }
        else if(ang < -90f&&hit == false)
        {
            Vector3 pos = transform.position;
            //rb.velocity = new Vector3(-10, 0, 50);

            if (enemy != null)
            {
                float distance = Vector3.Distance(pos, enemy.EnemyPos());
                float step = Time.deltaTime * Vec / distance;
                Vector3 v = Vector3.Lerp(pos, enemy.EnemyPos(), step);
                transform.LookAt(v);
                transform.position = v;

            }
        }
        else if(enemy == null|| hit == true)
        {
            transform.position = enemy.EnemyPos();
        }

        damage();

        if(Time.timeScale == 0f)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter(Collider c)
    {
        hit = true;
    }

    void damage()
    {
        if (hit == true || transform.position.z >= enemy.EnemyPos().z + 1)
        {
            enemy.DamageHorming();
            Destroy(gameObject);
            hit = false;
        }
    }

}
