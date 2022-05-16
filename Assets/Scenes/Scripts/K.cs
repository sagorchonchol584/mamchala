using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class K : MonoBehaviour
{
    public GameObject[] ob;
    public static int K_Pont;
    public static bool istureK;
    public int add;
    public static int zoresK;
    public static bool iszoresK;
    public TextMeshProUGUI number_text;
    public void Start()
    {
        istureK = true;
    }
    public void Update()
    {
        if (istureK) { test_circlr(); }
        if (iszoresK) { emtry_value(); }
        number_text.text = "" + add;
    }
    public void test_circlr()
    {
        add += K_Pont;
        for (int i = 0; i < add; i++)
        {
            ob[i].SetActive(true);
        }
        istureK = false;
    }

    public void emtry_value()
    {
        add = 0;
        for (int i = 0; i < zoresK; i++)
        {
            ob[i].SetActive(false);
        }
        iszoresK = false;
    }
}