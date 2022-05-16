using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class G : MonoBehaviour
{
    public GameObject[] ob;
    public static int G_Pont;
    public static bool istureG;
    public int add;
    public static int zoresG;
    public static bool iszoresG;
    public TextMeshProUGUI number_text;
    public void Start()
    {
        istureG = true;
    }
    public void Update()
    {
        if (istureG) { test_circlr(); }
        if (iszoresG) { emtry_value(); }
        number_text.text = "" + add;
    }
    public void test_circlr()
    {
        add += G_Pont;
        for (int i = 0; i < add; i++)
        {
            ob[i].SetActive(true);
        }
        istureG = false;
    }

    public void emtry_value()
    {
        add = 0;
        for (int i = 0; i < zoresG; i++)
        {
            ob[i].SetActive(false);
        }
        iszoresG = false;
    }
}