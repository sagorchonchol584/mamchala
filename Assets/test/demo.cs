using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class demo : MonoBehaviour
{
 
  public void plays()
    {
        SceneManager.LoadScene("SampleScene");
    }

     public void again()

    {
        SceneManager.LoadScene("demo");
    }


}
