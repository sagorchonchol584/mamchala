using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class new_point : MonoBehaviour
{
    public static int point;
    public GameObject[] ob;
   
    public void Update()
    {    
            test_circlr();   
    }
    public void test_circlr()
    {
            for (int i = 0; i < point; i++)
            {
             ob[i].SetActive(true);
            }
    } 
   
}


