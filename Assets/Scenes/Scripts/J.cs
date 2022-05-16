using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class J : MonoBehaviour
{
    public GameObject[] ob;
    public static int J_Pont;
    public static bool istureJ;
    public int add;
    public static int zoresJ;
    public static bool iszoresJ;
    public TextMeshProUGUI number_text;
    public void Start()
    {
        istureJ = true;
    }
    public void Update()
    {
        if (istureJ) { test_circlr(); }
        if (iszoresJ) { emtry_value(); }
        number_text.text = "" + add;
    }
    public void test_circlr()
    {
        add += J_Pont;
        for (int i = 0; i < add; i++)
        {
            ob[i].SetActive(true);
        }
        istureJ = false;
    }

    public void emtry_value()
    {
        add = 0;
        for (int i = 0; i < zoresJ; i++)
        {
            ob[i].SetActive(false);
        }
        iszoresJ = false;
    }
}