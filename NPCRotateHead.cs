using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCRotateHead : MonoBehaviour
{

    public static bool isRotate = false;



    float cur_Time = 0;

    int randoM_Time = 0;
    // Start is called before the first frame update
    void Start()
    {
        ResetTime();
    }

    // Update is called once per frame
    void Update()
    {
        cur_Time += Time.deltaTime;
        if(cur_Time >= randoM_Time)
        {
            isRotate = true;
            // zhuantou
            GetComponent<Animator>().SetBool("isRotate", true);
         
            Invoke("ResetTime",2f);
           // Debug.Log("1111111");

        }
        else
        {
            GetComponent<Animator>().SetBool("isRotate", false);
            //zhuan hui qu 
            isRotate = false;
            //Debug.Log("222222");
        }
    }


    void ResetTime()
    {
        
        cur_Time = 0;
        randoM_Time = Random.Range(3, 6);
        Debug.Log("已转头，下一次转头时间为：" + randoM_Time);
    }
}
