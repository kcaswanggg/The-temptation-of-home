using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAndClickController : MonoBehaviour
{
    Camera mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {//check if the user is pressing the mouse button
        if (Input.GetButton("Fire1")) //by default, the left mouse is hooked to "Fire1"
        {
            //get the position of the mouse pointer (in screen space)
            Vector3 mousePos = Input.mousePosition;
            //calculate the position of the mouse in world space (this is a position just in front of the camera, not the point on the
            //world floor
            Vector3 point = mainCamera.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, mainCamera.nearClipPlane));
            //calculate the direction from the camera to the world space mouse position
            Vector3 direction = point - mainCamera.transform.position;
            //ensure the direction is a unit vector
            direction.Normalize();
            //cast a ray from the ca
            //
            //mera in the direction of the world space mouse position

            RaycastHit hit;
            if (Physics.Raycast(mainCamera.transform.position, direction, out hit))
            {
                //the point that the ray hits geometry is the point we are interested in
                //Debug.Log("pointing at " + hit.collider.name);
                transform.GetComponent<C_P>().SetTarget(hit.point);


            }

            //if (Physics.Raycast(mainCamera.ScreenPointToRay(mousePos), out hit))
            //{
            //    the point that the ray hits geometry is the point we are interested in
            //    Debug.Log("pointing at " + hit.collider.name);
            //    transform.GetComponent<C_P>().SetTarget(hit.point);


            //}
        }
    }
}


