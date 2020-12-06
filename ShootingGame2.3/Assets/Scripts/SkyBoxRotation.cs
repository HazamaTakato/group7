using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxRotation : MonoBehaviour
{
    float rota = 0;
    public float second;

    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.skybox.SetFloat("_Rotation", 0);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void RightRota(float s,float fpr)
    {

        second += 0.1f;
        if(second > s)
        {
            second = 0;
            Time.timeScale = 1;
            return;
        }
        else if(second < s)
        {
            rota += fpr;
        }

        RenderSettings.skybox.SetFloat("_Rotation", rota);
    }
    public void LeftRota(float s, float fpr)
    {

        second += 0.1f;
        if (second > s)
        {
            second = 0;
            Time.timeScale = 1;
            return;
        }
        else if (second < s)
        {
            rota -= fpr;
        }

        RenderSettings.skybox.SetFloat("_Rotation", rota);
    }
}
