using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class E : MonoBehaviour
{
    public GameObject[] ob;
    public static int E_Pont;
    public static bool istureE;
    public int add;
    public static int zoresE;
    public static bool iszoresE;
    public TextMeshProUGUI number_text;
    public void Start()
    {
        istureE = true;
    }
    public void Update()
    {
        if (istureE) { test_circlr(); }
        if (iszoresE) { emtry_value(); }
        number_text.text = "" + add;
    }
    public void test_circlr()
    {
        add += E_Pont;
        for (int i = 0; i < add; i++)
        {
            ob[i].SetActive(true);
        }
        istureE = false;
    }

    public void emtry_value()
    {
        add = 0;
        for (int i = 0; i < zoresE; i++)
        {
            ob[i].SetActive(false);
        }
        iszoresE = false;
    }
}