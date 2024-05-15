using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class UI_PosScript : MonoBehaviour
{
    private GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.Find("/Implant01");
    }

    // Update is called once per frame
    void Update()
    {
        if (obj != null)
        {
            // convert the obj's position from world space to screen space
            Vector3 onScreenPosition = Camera.main.WorldToScreenPoint(obj.transform.position);

            // position adaptation to not intersect with object
            Vector3 posAdapt = new Vector3(0, 100, 0);
            // set the position of the UI text to match the screen position
            transform.position = onScreenPosition + posAdapt;
        }
    }
}
