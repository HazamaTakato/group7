using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BossController1 : MonoBehaviour
{

    public GameObject BlackEnemyBullet;
    public GameObject OrangeEnemyBullet;
    public GameObject PinkEnemyBullet;
    public float X_Speed;
    public float Y_Speed;
    public float Z_Speed;
    float orangeIntervalTime;
    float blackIntervalTime;
    float pinkIntervalTime;
    EnemyManager manager;

    float rotateZ;

    public int hp;

    List<Quaternion> quat;
    List<GameObject> beb;
    List<GameObject> peb;
    List<GameObject> oeb;
    // Start is called before the first frame update
    void Start()
    {
        orangeIntervalTime = 0;
        blackIntervalTime = 0;
        pinkIntervalTime = 0;
        quat = new List<Quaternion>();
        beb = new List<GameObject>();
        peb = new List<GameObject>();
        oeb = new List<GameObject>();
        manager = GetComponent<EnemyManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (manager.hp <= 0)
        {
            SceneManager.LoadScene("ClearScene");
        }
        transform.Translate(1 * X_Speed, 1 * Y_Speed, 1 * Z_Speed);
        if (transform.position.x > 2 || transform.position.x < -2)
        {
            X_Speed *= -1;
        }

        if (transform.position.y > 5 || transform.position.y < 0)
        {
            Y_Speed *= -1;
        }

        if (transform.position.z > 31 || transform.position.z < 19)
        {
            Z_Speed *= -1;
        }

        rotateZ = rotateZ + 5;

        for (int i = 0; i <= 12; i++)
        {
            int y = i * 30;
            quat.Add(Quaternion.Euler(0, y, 0));
        }

        blackIntervalTime += Time.deltaTime;

        if (blackIntervalTime >= 2.0f)
        {
            blackIntervalTime = 0.0f;

            beb.Add(GameObject.Instantiate(BlackEnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation));
        }

        pinkIntervalTime += Time.deltaTime;

        if (pinkIntervalTime >= 1.0f)
        {
            pinkIntervalTime = 0.0f;
            peb.Add(GameObject.Instantiate(PinkEnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(0,180,0)));

        }


        orangeIntervalTime += Time.deltaTime;

        if (orangeIntervalTime >= 5.0f)
        {
            orangeIntervalTime = 0.0f;
            for (int i = 0; i <= 6; i++)
            {
                oeb.Add(GameObject.Instantiate(OrangeEnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat[i + 3]));
            }
        }
    }
}
