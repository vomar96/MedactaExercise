using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeScript : MonoBehaviour
{
    public Color doNotTouchColor;
    public Color touchColor;
    public Color correspondColor;
    private int objectState;
    private Renderer objRenderer;
    private float angleTolerance;
    private float distanceTolerance;
    private bool isOverlapping = false;
    private bool checkAngleTolerance;
    private bool checkDistanceTolerance;  

    [SerializeField] private GameObject obj1;
    [SerializeField] private GameObject obj2;

    // Start is called before the first frame update
    void Start()
    {
        // get the renderer of the component
        objRenderer = GetComponent<MeshRenderer>();
        // set the tolerances
        angleTolerance = 10.0f;
        distanceTolerance = 0.01f;
    }

    // check when meshes begins to overlap
    void OnTriggerEnter(Collider other)
    {
        isOverlapping = true;
    }

    void OnTriggerExit(Collider other)
    {
        isOverlapping = false;
    }
 
    // Update is called once per frame
    void Update()
    {
        // compare difference of rotation with tolerance
        checkAngleTolerance = Vector3.Distance(obj1.transform.eulerAngles, obj2.transform.eulerAngles) < angleTolerance;
        // compare difference of distance with tolerance
        checkDistanceTolerance = Vector3.Distance(obj1.transform.position, obj2.transform.position) < distanceTolerance;
        
        // define object states
        // if object is overlapping & angle in tolerance
        if (isOverlapping && checkAngleTolerance && checkDistanceTolerance) 
        {
            objectState = 2;
        }
        else if (isOverlapping)
        {
            objectState = 1;
        }
        else
        {
            objectState = 0;
        }

        // change material color depending on the objectState
        switch (objectState)
        {
            case 0:
                objRenderer.material.color = doNotTouchColor;
                break;
            case 1:
                objRenderer.material.color = touchColor;
                break;
            case 2:
                objRenderer.material.color = correspondColor;
                break;
            default:
                objRenderer.material.color = doNotTouchColor;
                break;
        }
    }
}
