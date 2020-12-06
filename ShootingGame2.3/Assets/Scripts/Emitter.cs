using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Emitter : MonoBehaviour
{
    // Waveプレハブを格納する
    public GameObject[] waves;
    PlayerHit player;
    SkyBoxRotation SBR;
    int i = 0;

    bool rotaDir;

    // 現在のWave
    private int currentWave;

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerHit>();

        StartCoroutine("col");
    }

    void Update()
    {
        if (player.IsDead())
        {
            SceneManager.LoadScene("BadEnding");
        }
    }

    IEnumerator col()
    {
        //SBR = GameObject.Find("SkyBoxRota").GetComponent<SkyBoxRotation>();

        // Waveが存在しなければコルーチンを終了する
        if (waves.Length == 0)
        {
            yield break;
        }

        while (true)
        {
            // Waveを作成する
            GameObject wave = (GameObject)Instantiate(waves[currentWave], transform.position, Quaternion.identity);

            // WaveをEmitterの子要素にする
            wave.transform.parent = transform;

            // Waveの子要素のEnemyが全て削除されるまで待機する
            while (wave.transform.childCount != 0)
            {
                yield return new WaitForEndOfFrame();
            }

            // Waveの削除
            Destroy(wave);
            

            // 格納されているWaveを全て実行したらEnding
            if (waves.Length <= ++currentWave)
            {
                SceneManager.LoadScene("ClearScene");
                yield break;
            }
        }
    }
}
