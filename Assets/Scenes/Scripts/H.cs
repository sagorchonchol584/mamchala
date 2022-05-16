using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class H : MonoBehaviour
{
    public GameObject[] ob;
    public static int H_Pont;
    public static bool istureH;
    public int add;
    public static int zoresH;
    public static bool iszoresH;
    public TextMeshProUGUI number_text;
    public void Start()
    {
        istureH = true;
    }
    public void Update()
    {
        if (istureH) { test_circlr(); }
        if (iszoresH) { emtry_value(); }
        number_text.text = "" + add;
    }
    public void test_circlr()
    {
        add += H_Pont;
        for (int i = 0; i < add; i++)
        {
            ob[i].SetActive(true);
        }
        istureH = false;
    }

    public void emtry_value()
    {
        add = 0;
        for (int i = 0; i < zoresH; i++)
        {
            ob[i].SetActive(false);
        }
        iszoresH = false;
    }
}
