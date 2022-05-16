using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class I : MonoBehaviour
{
    public GameObject[] ob;
    public static int I_Pont;
    public static bool istureI;
    public int add;
    public static int zoresI;
    public static bool iszoresI;
    public TextMeshProUGUI number_text;
    public void Start()
    {
        istureI = true;
    }
    public void Update()
    {
        if (istureI) { test_circlr(); }
        if (iszoresI) { emtry_value(); }
        number_text.text = "" + add;
    }
    public void test_circlr()
    {
        add += I_Pont;
        for (int i = 0; i < add; i++)
        {
            ob[i].SetActive(true);
        }
        istureI = false;
    }

    public void emtry_value()
    {
        add = 0;
        for (int i = 0; i < zoresI; i++)
        {
            ob[i].SetActive(false);
        }
        iszoresI = false;
    }
}