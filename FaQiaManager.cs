using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaQiaManager : MonoBehaviour
{

    public Transform boy;
    public Transform girl;
    public GameObject success;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Vector3.Distance(boy.position, transform.position));

        if(Vector3.Distance(boy.position, transform.position) < 3f)
        {
            success.SetActive(true);
        }
    }
}
