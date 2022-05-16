using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class new_point_second : MonoBehaviour
{
    public static int points;
    public GameObject[] ob;

    public void Update()
    {
        test_circlr();
    }
    public void test_circlr()
    {
        for (int i = 0; i < points; i++)
        {
            ob[i].SetActive(true);
        }
    }
}
