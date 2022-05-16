using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class F : MonoBehaviour
{
    public GameObject[] ob;
    public static int F_Pont;
    public static bool istureF;
    public int add;
    public static int zoresF;
    public static bool iszoresF;
    public TextMeshProUGUI number_text;
    public void Start()
    {
        istureF = true;
    }
    public void Update()
    {
        if (istureF) { test_circlr(); }
        if (iszoresF) { emtry_value(); }
        number_text.text = "" + add;
    }
    public void test_circlr()
    {
        add += F_Pont;
        for (int i = 0; i < add; i++)
        {
            ob[i].SetActive(true);
        }
        istureF = false;
    }

    public void emtry_value()
    {
        add = 0;
        for (int i = 0; i < zoresF; i++)
        {
            ob[i].SetActive(false);
        }
        iszoresF = false;
    }
}