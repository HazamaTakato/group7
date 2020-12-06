using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    public int hp = 100;
    bool deadFlag = false;
    public GameObject Hitparticle;
    GameObject deleteParticle;

    // Start is called before the first frame update
    void Start()
    {
        deadFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(hp <= 0)
        {
            deadFlag = true;
        }
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.CompareTag("EnemyBullet"))
        {
            hp -= 10;
            Destroy(c.gameObject);
            Hitparticle = Instantiate(Hitparticle, transform.position, transform.rotation) as GameObject;
            ParticleEnd();
        }
    }
    public bool IsDead()
    {
        return deadFlag;
    }

    public int Hp()
    {
        return hp;
    }

    void ParticleEnd()
    {
        deleteParticle = GameObject.Find("Player Particle(Clone)(Clone)");
        //Destroy(deleteParticle,2f);
    }
}
