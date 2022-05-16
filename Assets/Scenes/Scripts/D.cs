using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class D : MonoBehaviour
{
    public GameObject[] ob;
    public static int D_Pont;
    public static bool istureD;
    public int add;
    public static int zoresD;
    public static bool iszoresD;
    public TextMeshProUGUI number_text;
    public void Start()
    {
        istureD = true;
    }
    public void Update()
    {
        if (istureD) { test_circlr(); }
        if (iszoresD) { emtry_value(); }
        number_text.text = "" + add;
    }
    public void test_circlr()
    {
        add += D_Pont;
        for (int i = 0; i < add; i++)
        {
            ob[i].SetActive(true);
        }
        istureD = false;
    }

    public void emtry_value()
    {
        add = 0;
        for (int i = 0; i < zoresD; i++)
        {
            ob[i].SetActive(false);
        }
        iszoresD = false;
    }
}