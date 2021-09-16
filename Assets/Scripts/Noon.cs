using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Noon : MonoBehaviour
{
   //Take B - Rotating around an axis
    public float rotationSpeed = 1;
    public float rotationLength = 10;
    public float sAngle;
    public float eAngle;
    float curVel = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        //Take A - SmoothDamping between two vectors 
        //this.transform.eulerAngles = startAngle;

        Vector3 angle = this.transform.eulerAngles;
        angle.z = sAngle;
        this.transform.eulerAngles = angle; 
    }

    // Update is called once per frame
    void Update()
    {
        //Take A - SmoothDamping between two vectors 
        //this.transform.eulerAngles = Vector3.SmoothDamp(this.transform.eulerAngles, endAngle, ref curVel, rotationSpeed);

        //Take B - Rotating around an axis. Worked as intended
        Vector3 tempAngle = this.transform.eulerAngles;
        tempAngle.z = tempAngle.z + rotationSpeed * Time.deltaTime;
        //tempAngle.z += rotationSpeed; 

        this.transform.eulerAngles = tempAngle; 
    }
}
