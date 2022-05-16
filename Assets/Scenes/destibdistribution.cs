using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destibdistribution : MonoBehaviour
{
    public static int distribution;
    public GameObject[] ob;
    public int points;

    public static int get_value;
    public static int is_all_get;
    public static bool is_get_value; 
    public static bool is_collection_va;
    public static int collection_va;
    public int add;
    public int addvalu;
    public int adds;
    public int value;
    public static bool is_distibution;
    
    public void Start()
    {
        is_get_value = true;
    }
    public void Update()
    {
         
        if (is_get_value) { test_circlr();}
        if (is_distibution) { emtry_value();}
        if (is_collection_va) { collection_valur();}
        
    }
    public void test_circlr()
    {
        add = is_all_get;
        addvalu = 0;
        for (int i = 0; i < add; i++)
        {
            ob[i].SetActive(true);
        }
        is_get_value = false;
    }

    public void emtry_value()
    {
        addvalu += get_value;
        for (int i = 0; i < addvalu; i++)
        {
            ob[i].SetActive(false);
        }
        is_distibution = false;
    }

    public void collection_valur()
    {
         value = collection_va;
       // Debug.Log("ADD" + collection_va);
        for (int i = 0; i < value; i++)
        {
            ob[i].SetActive(true);
        }
        is_collection_va = false;
        StartCoroutine(alldelete());
    }
    IEnumerator alldelete()
    {
        yield return new WaitForSeconds(2.8f);
        for (int i = 0; i < value; i++)
        {
            ob[i].SetActive(false);
        }
       
    }

}
