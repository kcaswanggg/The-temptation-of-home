using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTrigger : MonoBehaviour
{
    public GameObject gameover;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if(other.name.Contains("»ÀŒÔ"))
        {
            if(other.GetComponent<C_P>().isStop == false)
            {
                gameover.SetActive(true);
            }
        }
    }
}
