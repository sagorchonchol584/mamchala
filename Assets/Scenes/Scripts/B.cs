using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class B : MonoBehaviour
{
    public GameObject[] ob;
    public static int B_Pont;
    public static bool isture;
    public int add;
    public static int zores; 
    public static bool iszores;
    public TextMeshProUGUI number_text;
    public void Start()
    {
        isture = true;
    }
    public void Update()
    {
        if (isture) { test_circlr();}
        if (iszores) { emtry_value();}
         number_text.text = "" + add;
    }
    public void test_circlr()
    {
        add += B_Pont;
            for (int i = 0; i < add; i++)
            {
                    ob[i].SetActive(true); 
            }
        isture = false;
    }
    
    public void emtry_value()
    {
        add = 0;
        for (int i = 0; i < zores; i++)
            {
                    ob[i].SetActive(false);
            }
        iszores = false;
    }
}
