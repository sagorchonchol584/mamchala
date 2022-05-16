using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circlr : MonoBehaviour
{
    public GameObject ob;
    public float radius;
    public int amountToSpawn;
    public bool istrue;
    public void Update()
    {
        test_circlr();
    }
    public void test_circlr()
    {

        if (istrue)
        {
            for (int i = 0; i < amountToSpawn; i++)
            {
                float angle = i * Mathf.PI * 2f / amountToSpawn;
                Vector3 newPos = new Vector3(transform.position.x+Mathf.Cos(angle) * radius, transform.position.y + Mathf.Sin(angle) * radius,0f);
               GameObject g = Instantiate(ob, newPos, Quaternion.identity);


                Color background = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
                g.transform.parent = gameObject.transform;
                g.GetComponent<SpriteRenderer>().material.SetColor("_Color", background);
                istrue = false;


            }
        }
    }
}
