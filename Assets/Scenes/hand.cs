using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hand : MonoBehaviour
{
   
    private string player, chacks,chevktwo;
    public static int button_value;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "CHACKTWO")
        {
            chevktwo = PlayerPrefs.GetString(allstatice.colision_tag_twos);
            Movement_forword.is_Collection = true;
            Movement_forword.is_colision_two = false;
            Movement_forword.is_Chack = true;
            StartCoroutine(collection_tag_two());

        } 
        if (collision.gameObject.tag == "CHACK")
        {
            chacks = PlayerPrefs.GetString(allstatice.colision_tag);
            Movement_forword.chack_value = 1;
            Movement_forword.count++;
            Movement_forword.instantiation = true;
           StartCoroutine(collection_tag());
           

        } 
        if (collision.gameObject.tag == "ADD")
        {
            player = PlayerPrefs.GetString(allstatice.save);
            StartCoroutine(add_wait());
            Movement_forword.movement_tag = false;
            Movement_forword.movement_value = 1;
            Movement_forword.instantiation = true; 
            Movement_forword.is_Start = false;  
            destibdistribution.is_get_value = true;
            show_points(button_value);
         
           

        }
        if (collision.gameObject.tag == "A")
        {   
            A.A_Pont=1;
            A.istureA = true;

            destibdistribution.get_value = 1;
            destibdistribution.is_distibution = true;

            Movement_forword.count++;
            Movement_forword.movement_value = 1;
            Movement_forword.instantiation = true;
        }

        if (collision.gameObject.tag == "B")
        {
            destibdistribution.get_value = 1;
            destibdistribution.is_distibution = true;
            B.B_Pont=1;
            B.isture = true;
            Movement_forword.count++;
            Movement_forword.movement_value = 1;
            Movement_forword.instantiation = true;
        }

        if (collision.gameObject.tag == "C")
        {
            destibdistribution.get_value = 1;
            destibdistribution.is_distibution = true;
            C.C_Pont=1;
            C.istureC = true;
            Movement_forword.count++;
            Movement_forword.movement_value = 1;
            Movement_forword.instantiation = true;
        }

        if (collision.gameObject.tag == "D")
        {
            destibdistribution.get_value = 1;
            destibdistribution.is_distibution = true;
            D.D_Pont=1;
            D.istureD = true;
            Movement_forword.count++;
            Movement_forword.movement_value = 1; 
            Movement_forword.instantiation = true;
        }

        if (collision.gameObject.tag == "E")
        {
            destibdistribution.get_value = 1;
            destibdistribution.is_distibution = true;
            E.E_Pont=1;
            E.istureE = true;
            Movement_forword.count++;
            Movement_forword.movement_value = 1;
            Movement_forword.instantiation = true;
        }

        if (collision.gameObject.tag == "F")
        {
            destibdistribution.get_value = 1;
            destibdistribution.is_distibution = true;
            F.F_Pont=1;
            F.istureF = true;
            Movement_forword.count++;
            Movement_forword.movement_value = 1;
            Movement_forword.instantiation = true;
        }

        if (collision.gameObject.tag == "G")
        {
            destibdistribution.get_value = 1;
            destibdistribution.is_distibution = true;
            G.G_Pont = 1;
            G.istureG = true;
            Movement_forword.count++;
            Movement_forword.movement_value = 1;
            Movement_forword.instantiation = true;
        }

        if (collision.gameObject.tag == "H")
        {
            destibdistribution.get_value = 1;
            destibdistribution.is_distibution = true;
            H.H_Pont = 1;
            H.istureH = true;
            Movement_forword.count++;
            Movement_forword.movement_value = 1;
            Movement_forword.instantiation = true;
        }

        if (collision.gameObject.tag == "I")
        {
            destibdistribution.get_value = 1;
            destibdistribution.is_distibution = true;
            I.I_Pont = 1;
            I.istureI = true;
            Movement_forword.count++;
            Movement_forword.movement_value = 1;
            Movement_forword.instantiation = true;
        }

        if (collision.gameObject.tag == "J")
        {
            destibdistribution.get_value = 1;
            destibdistribution.is_distibution = true;
            J.J_Pont = 1;
            J.istureJ = true;
            Movement_forword.count++;
            Movement_forword.movement_value = 1;
            Movement_forword.instantiation = true;
        }  

        if (collision.gameObject.tag == "K")
        {
            destibdistribution.get_value = 1;
            destibdistribution.is_distibution = true;
            K.K_Pont = 1;
            K.istureK = true;
            Movement_forword.count++;
            Movement_forword.movement_value = 1;
            Movement_forword.instantiation = true;
        } 

        if (collision.gameObject.tag == "L")
        {
            destibdistribution.get_value = 1;
            destibdistribution.is_distibution = true;
            L.L_Pont = 1;
            L.istureL = true;
            Movement_forword.count++;
            Movement_forword.movement_value = 1;
            Movement_forword.instantiation = true;
        }
         
     

        IEnumerator collection_tag()
        {
            yield return new WaitForSeconds(0.35f);
            collision.gameObject.tag = chacks;
        }
 
        IEnumerator collection_tag_two()
        {
            yield return new WaitForSeconds(0.25f);
            collision.gameObject.tag = chevktwo;
        }

        IEnumerator add_wait()
        {
            yield return new WaitForSeconds(0.25f);
            collision.gameObject.tag = player;
        }

    } 

    public void Update()
    {
        
    }
    public void show_points(int bmt)
    {
        switch (bmt)
        {
            case 0:
                A.iszoresA = true;
           
                break;
            case 1:
                B.iszores = true;
            
                break;
            case 2:
                C.iszoresC = true;
               
                break;
            case 3:
                D.iszoresD = true;
             
                break;
            case 4:
                E.iszoresE = true;
               
                break;
            case 5:
                F.iszoresF = true;
           
                break;
            case 6:
                G.iszoresG = true;
              
                break;
            case 7:
                H.iszoresH = true;
               
                break;
            case 8:
                I.iszoresI = true;
             
                break;
            case 9:
                J.iszoresJ = true;
             
                break;
            case 10:
                K.iszoresK = true;
         
                break;
            case 11:
                L.iszoresL = true;
           
                break;
            default:
                break;
        }
    }
    
}
