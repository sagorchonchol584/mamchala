using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class points : MonoBehaviour
{
    private int i;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "hand")
        {
          //  i++;
         //   Movement_forword.tt++;
           // new_point.point++;
            Movement_forword.instantiation=true;  
        }

        StartCoroutine(Next_Step());
     
    }

    IEnumerator Next_Step()
    {
        yield return new WaitForSeconds(20f);
    }
}
