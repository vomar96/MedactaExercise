using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragScript : MonoBehaviour
{
    // y coordinate
    private float yCoordinate;
    private bool dragging;
    private Plane plane;
    // on mouse down start dragging
    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            dragging = true;
        }
    }
    // on mouse up stop dragging
    void OnMouseUp() 
    {
        if (Input.GetMouseButtonUp(0))
        {
            dragging = false;
        }
    }  
    
    // Start is called before the first frame update
    void Start()
    {
        // define height of objects
        yCoordinate = 1.0f;
        // create plane of intersection
        plane = new Plane(Vector3.up, new Vector3(0, yCoordinate, 0));
    }

    // Update is called once per frame
    void Update()
    {
        // while dragging 
        if (dragging)
        {
            // cast ray point from cursor to invisible plane
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float enter;
            if (plane.Raycast(ray, out enter))
            {
                Vector3 intersectionPoint = ray.GetPoint(enter);
                // transform object position
                transform.position = intersectionPoint;
            }
        }
    }
}
