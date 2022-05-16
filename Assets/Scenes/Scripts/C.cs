using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class C : MonoBehaviour
{
    public GameObject[] ob;
    public static int C_Pont;
    public static bool istureC;
    public int add;
    public static int zoresC;
    public static bool iszoresC;
    public TextMeshProUGUI number_text;
    public void Start()
    {
        istureC = true;
    }
    public void Update()
    {
        if (istureC) { test_circlr(); }
        if (iszoresC) { emtry_value(); }
        number_text.text = "" + add;
    }
    public void test_circlr()
    {
        add += C_Pont;
        for (int i = 0; i < add; i++)
        {
            ob[i].SetActive(true);
        }
        istureC = false;
    }

    public void emtry_value()
    {
        add = 0;
        for (int i = 0; i < zoresC; i++)
        {
            ob[i].SetActive(false);
        }
        iszoresC = false;
    }
}
