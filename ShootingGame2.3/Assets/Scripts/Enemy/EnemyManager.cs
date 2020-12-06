using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public int hp = 0;
    bool hitColor;
    public float second;
    public GameObject[] item;

    public GameObject Hitparticle;
    public GameObject Deadparticle;

    AudioSource audio;
    public AudioClip sound1;


    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            int itemNumber = Random.Range(0, item.Length);
            if(item[itemNumber] == null)
            {
                return;
            }
            else
            {
                Instantiate(item[itemNumber], transform.position, transform.rotation);
            }
            ParticleEnd();
            audio.PlayOneShot(sound1);
            Destroy(gameObject);
            Deadparticle = Instantiate(Deadparticle, transform.position, transform.rotation) as GameObject;
        }
    }



    public void DamageHorming()
    {
        hp -= 5;
        Hitparticle = Instantiate(Hitparticle, transform.position, transform.rotation) as GameObject;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("PlayerBullet"))
        {
            hp -= 10;
            Hitparticle = Instantiate(Hitparticle, transform.position, transform.rotation) as GameObject;
        }
    }

    public Vector3 EnemyPos()
    {
        return transform.position;
    }
    
    void ParticleEnd()
    {
        Destroy(Hitparticle,10f);
    }
}
