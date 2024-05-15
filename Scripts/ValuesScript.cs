using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValuesScript : MonoBehaviour
{
    private float angle;
    private float distance;
    private Text angle_val;
    private Text dist_val;

    [SerializeField] private GameObject obj1;
    [SerializeField] private GameObject obj2;


    // Start is called before the first frame update
    void Start()
    {
        obj1 = GameObject.Find("/Implant01");
        obj2 = GameObject.Find("/Implant02");
        // get canvas to modify texts
        GameObject canvas = GameObject.Find("Canvas");
        // get text components
        angle_val = canvas.transform.Find("Image/Angle_value").GetComponent<Text>();
        dist_val = canvas.transform.Find("Image/Dist_value").GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        // create vector between two objs
        Vector3 objsVect3 = obj1.transform.position - obj2.transform.position;
        // get angle between object vector and world forward rounded to .01 degree
        angle = Mathf.Round(Vector3.SignedAngle(Vector3.forward, objsVect3, Vector3.up) * 100f) / 100f;
        // get distance between objects - rounded to .01 cm
        distance = Mathf.Round(Vector3.Distance(obj1.transform.position, obj2.transform.position) *10000f) / 100f;
        // assign values
        angle_val.text = angle.ToString() + "\u00B0";
        dist_val.text = distance.ToString() + " cm";
    }
}
