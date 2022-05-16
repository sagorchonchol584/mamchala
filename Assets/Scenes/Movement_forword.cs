using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Movement_forword : MonoBehaviour
{

    public GameObject animator;
    public GameObject[] move;
    public GameObject[] start;
    public GameObject[] ob;
    public GameObject Player_hand;
    public GameObject winner_planel;
    public SpriteRenderer sr;
    public RectTransform recttramsform;
    public RectTransform animationRect;
    public GameObject marbel;
    public GameObject first_click, second_click;

    public static bool movement_tag;
    public static bool is_colision_two;
    public static bool isrunign;
    public static bool instantiation; 
    public static bool instantiation_point;
    public static bool is_Start;
    public static bool is_Chack;
    public static bool is_Collection;

    // Gameover check and over panel
    public bool is_check_game_over;
    public int first_player_value;
    public int second_player_value;
    public GameObject gameOver;
    public TextMeshProUGUI player_name_show, score_palyer_show;


    public bool is_Player_alter;
    public bool score_is_text;
    public bool is_animation;
    public bool is_move_extra;
    public bool is_colision;
    public bool score;
    public bool funtion_on;

    public static int movement_value; 
    public static int count;
    public static int get_value;
    public static int chack_value;
    public int movement_value_add;
    public int TotalScore;
    public int click;
    public int speed;
    public int first_score_total, second_score_total;
    public int startPostion;

    public int distribution_value;
    public int B_b_v;
    public int C_b_v;
    public int D_b_v;
    public int E_b_v;
    public int F_b_v;
    public int G_b_v;
    public int H_b_v;
    public int I_b_v;
    public int J_b_v;
    public int bmttwovalueadd;

    // just for UI value 
    public TextMeshProUGUI[] number_text;
    public TextMeshProUGUI first_score, second_score;
    public TextMeshProUGUI value;
    public TextMeshProUGUI first_player, second_player;
    public Button[] button;
    public Button[] buttons;
    
    // this physics funtion matarial 
    public CircleCollider2D circle2d;



    public Button yes_button, no_button;
    public bool winner_chance, button_is, button_is_yes;
    public int valuepass, bt_indext, chack_value_fun;




    void Start()
    {

        startPostion = 0;
        
        A.A_Pont = 4;
        B.B_Pont = 4;
        C.C_Pont = 4; 
        D.D_Pont = 4;
        E.E_Pont = 4;
  //------------------------
        F.F_Pont = 4;
        G.G_Pont = 4;
        H.H_Pont = 4;
        I.I_Pont = 4;
        J.J_Pont = 4;

 //------------------------
 /*
        A.A_Pont = 4;
        B.B_Pont = 1;
        C.C_Pont = 4;
        D.D_Pont = 1;
        E.E_Pont = 4;
        //------------------------
        F.F_Pont = 0;
        G.G_Pont = 4;
        H.H_Pont = 0;
        I.I_Pont = 4;
        J.J_Pont = 0;
 */
    }
  
      
    void Update()
    {

     
        if (is_Player_alter)
        {
            first_Player_bt_funtion();
        }
        else
        {
            second_Player_bt_funtion();
        }
        
      
        if (isrunign)
        {
            newtest();
               test();             
        }
        else
        { 
            count = 0;
            movement_value_add = 0;
            circle2d.enabled = false;
            float step = speed * Time.deltaTime;
            Player_hand.transform.position = Vector2.MoveTowards(Player_hand.transform.position, start[startPostion].transform.position, step);
        }

        if (funtion_on)
        {
            funtion_point();
        }
        if (is_check_game_over) { teast();}
        
    }


    public void bt_funtion()
    {
        for (int i = 0; i < button.Length; i++)
        {
            int bt_index = int.Parse(button[i].name.ToString());
            int count = int.Parse(number_text[i].text.ToString());
            button[i].onClick.AddListener(() => button_values(count, bt_index));
        }     
    }
    public void teast()
    {
        for (int i = 0; i < button.Length; i++)
        {
            if (i < 5)
            { 
                int count = int.Parse(number_text[i].text.ToString());
                first_player_value += count; 
            }
            else
            {
                int counts = int.Parse(number_text[i].text.ToString());
                second_player_value += counts;
            } 
        }
        if (1 > first_player_value || 1 > second_player_value)
        {
            gameOver.SetActive(true);
            Player_hand.SetActive(false);
            if (second_score_total + second_player_value > first_score_total + first_player_value)
               {
                int results = second_score_total + second_player_value;
                player_name_show.text = "Second player win";
                score_palyer_show.text = "Score:" + results;
               } 
            else 
               {
                int resultstwo = first_score_total + first_player_value;
                player_name_show.text = "You Win";
                score_palyer_show.text = "You Score:" + resultstwo;
               }
        }
      //  Debug.Log("test two" + first_player_value);
        is_check_game_over = false;
    }

    public void first_Player_bt_funtion()
    {
        bt_funtion();
        startPostion = 0;
        first_player.enabled = true;
        second_player.enabled = false;
        first_click.SetActive(true);
        second_click.SetActive(false);

        if (is_animation)
        {
            animator.SetActive(true);
            animationRect.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            StartCoroutine(isrnimation());
        }
        else
        {
            animator.SetActive(false);           
        }


        if (score_is_text)
        {
            destibdistribution.is_collection_va = true;
            destibdistribution.collection_va = TotalScore;
            first_score_total += TotalScore;
            first_score.text = "A" + first_score_total;
            new_point.point = first_score_total;
            score_is_text = false;
        }

    } 
    public void second_Player_bt_funtion()
    {
        bt_funtion();
        startPostion = 1;
        first_player.enabled = false;
        second_player.enabled = true;
        first_click.SetActive(false);
        second_click.SetActive(true);

        if (is_animation)
        {
            animator.SetActive(true);
            animationRect.transform.rotation = Quaternion.Euler(0f, 0f, 180f);
            StartCoroutine(isrnimation());
        }
        else
        {
            animator.SetActive(false);        
        }
      
        if (score_is_text)
        {
            destibdistribution.is_collection_va = true;
            destibdistribution.collection_va = TotalScore;
            second_score_total += TotalScore;
            second_score.text = "B" + second_score_total;
            new_point_second.points = second_score_total;
            score_is_text = false;
        }
       
    }
    IEnumerator isrnimation()
    {
        yield return new WaitForSeconds(2f);
        is_animation = false;
    }
    public void handis(bool test)
    {
        if (test)
        {
            Player_hand.transform.position = new Vector3(start[0].transform.position.x, start[0].transform.position.y, start[0].transform.position.z);
            recttramsform.transform.rotation = Quaternion.Euler(0f, 0f, 0);
            sr.flipY = false;
           
        }
        else
        {
            Player_hand.transform.position = new Vector3(start[1].transform.position.x, start[1].transform.position.y, start[1].transform.position.z);
            recttramsform.transform.rotation = Quaternion.Euler(0f, 0f, 180f);
            sr.flipY = true;          
        }
    }  
    

    // I have useing movetoward implement, like condition and function 67-95
    public void newtest()
    {
       // tt = get_value;
        if (instantiation)
        { 
            movement_value_add += movement_value;

            if (movement_value_add==10)
            {
                movement_value_add = 0;
            }
            /* 
              if (10 > movement_value_add)
              { 

              }
              else 
              {
                  movement_value_add = 0;
              } 
            */
            instantiation = false;
        }    
    } 


    public void test()
    {
        
        B_b_v = count;
        C_b_v = get_value;
        distribution_value = get_value-B_b_v;
        value.text = "" + distribution_value;
       
        if (get_value>count)
        {
            float step = speed * Time.deltaTime;
            if (10 > movement_value_add)
            {
                Player_hand.transform.position = Vector2.MoveTowards(Player_hand.transform.position, move[movement_value_add].transform.position, step);
            }
            else 
            {
                movement_value_add = 0;
                Player_hand.transform.position = Vector2.MoveTowards(Player_hand.transform.position, move[0].transform.position, step);
            }
   
        }
        else
        {
            value_chack(movement_value_add);   
        }
    }

    public void value_chack(int i)
    {
        int cc;
        int bt_index = int.Parse(number_text[i].text.ToString());
        if (1 > bt_index)
        {
            if (9 > i)
            {
                cc = int.Parse(number_text[i + 1].text.ToString());
            }
            else
            {
                cc = int.Parse(number_text[0].text.ToString());
            }

            if (1 > cc)
            {
                winner_chance = false;
                button_is = false;
                is_Chack = false;
                is_colision = true;
                funtion_on = false;
                StartCoroutine(waiting_times());
                isrunign = false;

            }
            else
            {
                Pont_collection_trails(i);
            }
            //  Pont_collection(i);
        }
        else
        {
            button_values(bt_index, i);
            count = 0;
        }

    }



    public void Pont_collection_trails(int i)
    {
        if (!is_colision_two)
        {
            colision_two(i, i + 1);
            PlayerPrefs.SetInt(allstatice.funtion_point, i);
            is_colision_two = true;
           // if_value_is_zero(i);
            funtion_on = true;
            Debug.Log("Pont_collection_trails" + i);
        }
        get_value = 2;
        count = 0;
        
    }

    public void if_value_is_zero(int button_value)
    {
        if (9 > button_value)
        {
            if (8 > button_value)
            {
                if(7> button_value) { chack_value_fun = int.Parse(number_text[button_value + 3].text.ToString()); }
                else { chack_value_fun = int.Parse(number_text[0].text.ToString()); }
                Debug.Log("chack_value_fun" + button_value + "ff" + chack_value_fun);
            }
            else
            {
                chack_value_fun = int.Parse(number_text[2].text.ToString());
                Debug.Log("chack_value_fun" + chack_value_fun);
            }
            if (chack_value_fun < 1)
            {
                winner_chance = false;
                button_is = false;
                is_Chack = false;
                is_colision = true;
                funtion_on = false;
                StartCoroutine(waiting_times());
                isrunign = false;
                Debug.Log("chack_value_condition" + chack_value_fun);
            }
            else
            {
                funtion_on = true;
            }

        }
        else
        {
            
        }
    }

    public void funtion_point()
    {
        yes_button.onClick.AddListener(button_Click_for_winner_chance);
        no_button.onClick.AddListener(button_Click_for_winner_chance_no);
      
        if (is_Chack)
        {
        // new funtion include for chack value next point, if next is zero then call this funtion
            int button_value = PlayerPrefs.GetInt(allstatice.funtion_point);
         
            if (9 > button_value)
            {
                Debug.Log("main condition is true" + button_value);
                // Next is zero then call this funtion
                if(8> button_value) 
                {
                    bt_indext = int.Parse(number_text[button_value + 2].text.ToString());
                    
                } 
                else 
                {
                    bt_indext = int.Parse(number_text[0].text.ToString());
            
                } 
                int value = int.Parse(number_text[button_value + 1].text.ToString());
                if (1 > bt_indext)
                {
                
                   // Debug.Log("if true");
                    //----------------------------------
                    if (8 > button_value)
                    {
                        valuepass = int.Parse(number_text[button_value + 2].text.ToString());
                    }
                    else
                    {
                        valuepass = int.Parse(number_text[0].text.ToString());
                    }

                    if (1 > valuepass)
                    {
                        int results;
                        if (8 > button_value)
                        {
                            Debug.Log("valuechace" + button_value);
                            int valuechace;
                            results = int.Parse(number_text[button_value + 2].text.ToString());

                            if(7 > button_value)
                            {
                                valuechace = int.Parse(number_text[button_value + 3].text.ToString());
                            }
                            else
                            {
                                valuechace = int.Parse(number_text[0].text.ToString());
                            }
                   
                            if (valuechace < 1)
                            {
                                Debug.Log("dobule");
                                button_is = true;
                                winner_chance = false;
                            }
                        }
                        else
                        {
                            results = int.Parse(number_text[0].text.ToString());
                        }


                        if (winner_chance && 1 > results)
                        {
                            Debug.Log("winner_chance_true");
                            winner_chance = false;
                            winner_planel.SetActive(true);
                            is_colision = true;
                        }
                        // this funtion is lucky winner button yes and no
                        if (button_is)
                        {
                            Debug.Log("button_is_true");
                            winner_chance = false;
                            button_is = false;
                            collection_score(value, button_value + 1);
                            TotalScore = value;
                            score_is_text = true;
                            StartCoroutine(waiting_times());
                            is_Chack = false;
                            is_colision = true;
                            funtion_on = false;
                            isrunign = false;
                        }

                        if (button_is_yes)
                        {
                           
                            Debug.Log("button_is_yes_true"+ button_value);
                            button_is_yes = false;
                            colision_two(button_value + 2, button_value + 3);
                            collection_score(value, button_value + 1);
                            TotalScore = value;
                            score_is_text = true;
                            StartCoroutine(yes_changce(value, button_value));
                            is_Chack = false;

                        }
                    }
                   
                    // this funtion is lucky winner button yes and no close or exit
                    //----------------------------------
                }
                else
                {

                        Debug.Log(" is true if value zero geterthen" );
                        collection_score(value, button_value + 1);
                        TotalScore = value;
                        score_is_text = true;
                        StartCoroutine(waiting_times());
                        is_Chack = false;
                        is_colision = true;
                        funtion_on = false;
                        isrunign = false;

                    

                }

            }
            //----------------------------------------------------else--------------------------------------------------
            else
            {
               Debug.Log("main condition else" + button_value);
                int bt_indexts, valuestwo;
                if (button_value>9) 
                {
                    button_value = 1;
                    Debug.Log("Condition value");
                    valuestwo = int.Parse(number_text[button_value].text.ToString());
                }
                else
                {
                    button_value = 0;
                    Debug.Log(" else Condition value");
                    valuestwo = int.Parse(number_text[button_value].text.ToString());
                }
               
                bt_indexts = int.Parse(number_text[button_value].text.ToString());
               int value = int.Parse(number_text[button_value+1].text.ToString());

                if (value < 1) 
                {
                    if (winner_chance && 1 > value)
                    {
                        Debug.Log("winner_chance_else");
                        winner_chance = false;
                        winner_planel.SetActive(true);
                        is_colision = true;
                    }
                    else
                    {

                    }
                 
                    if (button_is)
                    {
                        Debug.Log("button_is_else");
                        winner_chance = false;
                        button_is = false;
                        collection_score(bt_indexts, button_value);
                        TotalScore = bt_indexts;
                        score_is_text = true;
                        StartCoroutine(waiting_times());
                        is_Chack = false;
                        is_colision = true;
                        funtion_on = false;
                        isrunign = false;
                    }

                    if (button_is_yes)
                    {
                       
                           button_value = -1;
                           Debug.Log("button_is_yes_else"+ button_value);
                           winner_chance = false;
                           button_is_yes = false;
                           colision_two(button_value + 2, button_value + 3);
                           collection_score(bt_indexts, button_value + 1);
                           TotalScore = bt_indexts;
                           score_is_text = true;
                           StartCoroutine(yes_changce(bt_indexts, button_value));
                           is_Chack = false; 
                    }

                }
                else
                {     
                  
                 Debug.Log("bt_ind " + bt_indexts +" one add "+ value +" bt "+ button_value);
                 collection_score(valuestwo, button_value);
                 TotalScore = value;
                 score_is_text = true;
                 StartCoroutine(waiting_times());
                 is_Chack = false;
                 is_colision = true;
                 funtion_on = false;
                 isrunign = false;
                
           /*
                 Debug.Log("if value zero geterthen"+ bt_indexts + value + button_value);
                 collection_score(bt_indexts, button_value);
                 TotalScore = value;
                 score_is_text = true;
                 StartCoroutine(waiting_times());
                 is_Chack = false;
                 is_colision = true;
                 funtion_on = false;
                 isrunign = false;    

*/

                }
            }      
        }
    }


public void button_Click_for_winner_chance()
    {
        winner_planel.SetActive(false);
        button_is_yes = true;
       
    }

    public void button_Click_for_winner_chance_no()
    {
        winner_planel.SetActive(false);
        button_is = true;
    }

    IEnumerator yes_changce(int bt,int i)
    {
        yield return new WaitForSeconds(2f);
        Pont_collection_trails(i + 2);
        movement_value_add = i+2;
        isrunign = true;
        funtion_on = true;
        // if (is_Chack == true) {collection_score(bt + 3, i + 3);}
        // Debug.Log("test to change" + i);
    }







/*
    public void Pont_collection(int i)
    {
        int bt_indext = int.Parse(number_text[i + 1].text.ToString());

        if (score)
        {
            collection_score(bt_indext, i + 1);
            TotalScore = bt_indext;
            score_is_text = true;
            score = false;
           StartCoroutine(waiting_times());
           
        }
        isrunign = false;
    }


*/

    public void colision_two(int bmt, int bmttwo)
    {
       

        if (11 == bmttwo)
        {
            bmttwovalueadd = 1;
        }
        else
        {
            bmttwovalueadd = bmttwo;
        }

        Debug.Log("tag" + bmt + " Tag two " + bmttwovalueadd);
        if (is_colision)
        {
            if (10 > bmt)
            {
                PlayerPrefs.SetString(allstatice.colision_tag, move[bmt].tag);
               // Debug.Log("it's bmt" + move[bmt].tag);
            }
            else
            {
                PlayerPrefs.SetString(allstatice.colision_tag, move[0].tag);
               // Debug.Log("it's bmt" + move[0].tag);
            }

            if ( 10 > bmttwovalueadd) 
            {
                PlayerPrefs.SetString(allstatice.colision_tag_twos, move[bmttwovalueadd].tag);
                //Debug.Log("it's bmttwo" + move[bmttwovalueadd].tag);
            }
             else 
            {
                PlayerPrefs.SetString(allstatice.colision_tag_twos, move[0].tag);
                //Debug.Log("it's bmttwo" + move[0].tag);
            }
          
            is_colision = false;
        }

        if (10 > bmt)
        {
            move[bmt].tag = "CHACK";
        }
        else
        {
            move[0].tag = "CHACK";
        };


        if (10 > bmttwovalueadd)
        {   
            move[bmttwovalueadd].tag = "CHACKTWO";
        }
        else 
        {
            move[0].tag = "CHACKTWO"; 
        };
     
    }
    IEnumerator waiting_times()
    {
        yield return new WaitForSeconds(2.8f);
        if (is_Player_alter)
        {
            is_Player_alter = false;
            handis(false);
            is_animation = true;
            score = true;
        }
        else
        {
            is_Player_alter = true;
            handis(true);
            is_animation = true;
            score = true;
        }
        is_check_game_over = true;
        first_player_value = 0;
        second_player_value = 0;
    }
    
 
    public void collection_score(int c, int bmts )
    {
        
        int bmt;
        if (11 == bmts)
        {
            bmt = 1;
        }
        else
        {
            bmt = bmts;
        }

        Debug.Log("c is count less" + c + "-//-" + bmt);
        switch (bmts)
            {
                case 0:
                    A.iszoresA = true;
                    A.zoresA = c;
                    break;
                case 1:
                    B.iszores = true;
                    B.zores = c;
                    break;
                case 2:
                    C.iszoresC = true;
                    C.zoresC = c;
                    break;
                case 3:
                    D.iszoresD = true;
                    D.zoresD = c;
                    break;
                case 4:
                    E.iszoresE = true;
                    E.zoresE = c;
                    break;
                case 5:
                    F.iszoresF = true;
                    F.zoresF = c;
                    break;
                case 6:
                    G.iszoresG = true;
                    G.zoresG = c;
                    break;
                case 7:
                    H.iszoresH = true;
                    H.zoresH = c;
                    break;
                case 8:
                    I.iszoresI = true;
                    I.zoresI = c;
                    break;
                case 9:
                    J.iszoresJ = true;
                    J.zoresJ = c;
                    break;
                case 10:
                    K.iszoresK = true;
                    K.zoresK = c;
                    break;
                case 11:
                    L.iszoresL = true;
                    L.zoresL = c;
                    break;
                default:
                  break;
            }
        button_is = false;
        winner_chance = true;
    }

   
    public void button_values(int c, int bmt)
    {
        switch (bmt)
        {
            case 0:
              //  A.iszoresA = true;
                A.zoresA = c;
                break;
            case 1:
              //  B.iszores = true;
                B.zores = c;
                break;
            case 2:
              //  C.iszoresC = true;
                C.zoresC = c;
                break; 
            case 3:
              //  D.iszoresD = true;
                D.zoresD = c;
                break;
            case 4:
              //  E.iszoresE = true;
                E.zoresE = c;
                break; 
            case 5:
              //  F.iszoresF = true;
                F.zoresF = c;
                break;
            case 6:
              //  G.iszoresG = true;
                G.zoresG = c;
                break; 
            case 7:
              //  H.iszoresH = true;
                H.zoresH = c;
                break;
            case 8:
             //   I.iszoresI = true;
                I.zoresI = c;
                break;
            case 9:
             //   J.iszoresJ = true;
                J.zoresJ = c;
                break;
            case 10:
              //  K.iszoresK = true;
                K.zoresK = c;
                break; 
            case 11:
              //  L.iszoresL = true;
                L.zoresL = c;
                break;
              default:
                Debug.Log("tests");
                break;
        }
        hand.button_value = bmt;
        circle2d.enabled = true;
        get_value = c;
        movement_value_add = bmt;
        isrunign = true;
        destibdistribution.is_all_get = c;
        colision(bmt); 
    }

    public void colision( int bmt)
    {
        if (!movement_tag)
        {
            PlayerPrefs.SetString(allstatice.save, move[bmt].tag);
            movement_tag = true;
        }  
        move[bmt].tag = "ADD";   
    }

    public void test_disribution_fun()
    {
        for (int i = 0; i < distribution_value; i++)
        {
            ob[i].SetActive(true);
        }
    }
  
}
