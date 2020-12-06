using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject rightBullet;
    public GameObject leftBullet;
    public GameObject hormingBullet;
    public GameObject leftHormingBullet;

    public float waitSeconds;
    public float hormingInt;
    float seconds;
    float hormingSeconds;
    Quaternion rotateZero;
    int shotMode;
    AudioSource audio;
    public AudioClip sound1;
    ItemManager itemNumber;

    Quaternion rightQuat;
    Quaternion leftQuat;

    public float threeWayInt;
    float threeWaySeconds;

    // Start is called before the first frame update
    void Start()
    {
        rotateZero = Quaternion.Euler(0, 0, 0);
        shotMode = 1;
        audio = GetComponent<AudioSource>();
        rightQuat = Quaternion.Euler(0, 10, 0);
        leftQuat = Quaternion.Euler(0, -10, 0);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void FixedUpdate()
    {
        ShotBullet();
    }

    void ShotBullet()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            seconds += Time.deltaTime;
            hormingSeconds += Time.deltaTime;
            threeWaySeconds += Time.deltaTime;
            if (shotMode == 1)
            {
                if (seconds > waitSeconds)
                {
                    seconds = 0f;
                    Instantiate(rightBullet, transform.position, rotateZero);
                    Instantiate(leftBullet, transform.position, rotateZero);
                    audio.PlayOneShot(sound1);

                }
                return;
            }
            else if (shotMode == 2)
            {
                if (hormingSeconds > hormingInt)
                {
                    hormingSeconds = 0f;
                    Instantiate(hormingBullet, transform.position, transform.rotation);
                    Instantiate(leftHormingBullet, transform.position, transform.rotation);
                    audio.PlayOneShot(sound1);
                }
                return;
            }
            else if(shotMode == 3)
            {
                if (threeWaySeconds > threeWayInt)
                {
                    threeWaySeconds = 0f;
                    Instantiate(leftBullet, transform.position, leftQuat);
                    Instantiate(leftBullet, transform.position, rotateZero);
                    Instantiate(rightBullet, transform.position, rotateZero);
                    Instantiate(rightBullet, transform.position, rightQuat);
                }
                return;
            }
        }
        seconds = waitSeconds;
        hormingSeconds = 0f;
        threeWaySeconds = threeWayInt;
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.CompareTag("Item"))
        {
            itemNumber = c.GetComponent<ItemManager>();
            shotMode = itemNumber.Number();
            Destroy(c.gameObject);
        }
    }
}
