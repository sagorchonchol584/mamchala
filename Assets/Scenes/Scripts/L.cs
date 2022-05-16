using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class L : MonoBehaviour
{
    public GameObject[] ob;
    public static int L_Pont;
    public static bool istureL;
    public int add;
    public static int zoresL;
    public static bool iszoresL;
    public TextMeshProUGUI number_text;
    public void Start()
    {
        istureL = true;
    }
    public void Update()
    {
        if (istureL) { test_circlr(); }
        if (iszoresL) { emtry_value(); }
        number_text.text = "" + add;
    }
    public void test_circlr()
    {
        add += L_Pont;
        for (int i = 0; i < add; i++)
        {
            ob[i].SetActive(true);
        }
        istureL = false;
    }

    public void emtry_value()
    {
        add = 0;
        for (int i = 0; i < zoresL; i++)
        {
            ob[i].SetActive(false);
        }
        iszoresL = false;
    }
}