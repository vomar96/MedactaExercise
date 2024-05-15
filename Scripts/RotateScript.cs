using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    private bool rotating;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        // when right click
        if (Input.GetMouseButtonDown(1))
        {
            // create a ray from the mouse cursor
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                // start rotating if object is clicked
                if (hit.transform == transform)
                {
                    rotating = true;
                }
            }
        }
        if (Input.GetMouseButtonUp(1))
        {
            rotating = false;
        }
        // when mouse is rotating
        if (rotating)
        {
            transform.Rotate(Vector3.right, Input.GetAxis("Mouse Y") * 0.5f);
            transform.Rotate(Vector3.up, Input.GetAxis("Mouse X") * 0.5f);
        }
    }
}
