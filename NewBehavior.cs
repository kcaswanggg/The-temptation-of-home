using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NewBehavior : MonoBehaviour
{
    public Text CountDown;
    public float timeleft;
    private bool IsCounting;

    public GameObject m_Image;

    // Start is called before the first frame update
    void Start()
    {
        IsCounting = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsCounting)
        {
            timeleft -= Time.deltaTime;

        }
        CountDown.text = timeleft.ToString(format: "0");
        if (timeleft <= 0 && IsCounting)
        {
            IsCounting = false;
            m_Image.SetActive(true);
        }
    }
}
           
        
