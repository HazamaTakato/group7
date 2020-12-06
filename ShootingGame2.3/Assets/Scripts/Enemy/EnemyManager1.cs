using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager1 : MonoBehaviour
{
    public Vector3 enemyPos;
    public int hp;
    public GameObject Hitparticle;
    public GameObject Deadparticle;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        enemyPos = transform.position;

        if (hp <= 0)
        {
            Destroy(gameObject);
            Deadparticle = Instantiate(Deadparticle, transform.position, transform.rotation) as GameObject;
            ParticleEnd();
        }
    }

    public Vector3 EnP()
    {
        return enemyPos;
    }

    public void damageHorming()
    {
        hp -= 5;
        Hitparticle = Instantiate(Hitparticle, transform.position, transform.rotation) as GameObject;
        ParticleEnd();
    }


    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("PlayerBullet"))
        {
            hp -= 10;
            Hitparticle = Instantiate(Hitparticle, transform.position, transform.rotation) as GameObject;
            ParticleEnd();
        }
    }

    void ParticleEnd()
    {
        Destroy(Hitparticle, 3f);
    }
}
