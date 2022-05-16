using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class A : MonoBehaviour
{

    public GameObject[] ob;
    public static int A_Pont;
    public static bool istureA;
    public int add;
    public static int zoresA;
    public static bool iszoresA;
    public TextMeshProUGUI number_text;

    public void Start()
    {
        istureA = true;
    }
    public void Update()
    {
        if (istureA) { test_circlr(); }
        if (iszoresA) { emtry_value(); }
        number_text.text = "" + add;
    }
    public void test_circlr()
    {
  
        add += A_Pont;
        for (int i = 0; i < add; i++)
        {
            ob[i].SetActive(true);
        }
        istureA = false;
    }

    public void emtry_value()
    {
      
        add = 0;
        for (int i = 0; i < zoresA; i++)
        {
            ob[i].SetActive(false);
        }
        iszoresA = false;
    }
}