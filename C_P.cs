using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using static UnityEngine.UIElements.UxmlAttributeDescription;
using UnityEngine.TextCore.Text;

public class C_P : MonoBehaviour
{

    Vector3 _Destination;

    bool isKiss = true;

    public bool isStop = false;
    // Start is called before the first frame update
    void Start()
    {
        //when we start, set the destination to whatever the current position is
        _Destination = transform.position;
    }
    // Update is called once per frame
    void Update()
    { //a variable to hold the current destination of the character

        //Debug.Log(NPCRotateHead.isRotate);
        //when updating, work out the direction we need to move in
        Vector3 MoveDirection = _Destination - transform.position;
        //Debug.Log(MoveDirection);
        //if the destination is a reasonable distance away, update the characters rotation to point in this direction
        if (MoveDirection.magnitude > 0.5f && !isStop)
        {
            MoveDirection.Normalize();
            transform.rotation = Quaternion.LookRotation(MoveDirection);
            //set a variable in the animation controller
            GetComponent<Animator>().SetFloat("WalkSpeed", 2.0f);

            transform.Translate(Vector3.forward * Time.deltaTime);
        }
        else

        {
            //set a variable in the animation controller
            GetComponent<Animator>().SetFloat("WalkSpeed", 0.0f);

            // zhuantou hou   shezhi  bie de dongzuo 
        }


        if(Input.GetKeyDown(KeyCode.F))
        {
            if(isKiss)
            {
                GetComponent<Animator>().SetBool("isKiss", false);
                isKiss = false;
            }
            else
            {
                GetComponent<Animator>().SetBool("isKiss", true);
                isKiss = true;
            }
          
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            if(isStop)
            {
                isStop = false;

            }
            else
            {
                isStop = true;
            }
        }

       

    }

    public void SetTarget(Vector3 TargetPos)
    {
        _Destination = TargetPos;
    }


    void OnFootstet()
    {

    }
}