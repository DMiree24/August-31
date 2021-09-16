using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wonder : MonoBehaviour
{
   float Speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temP = this.gameObject.transform.position;

        //temP.x = temP.x + Speed; 
        temP.x = temP.x + Speed;

        //float val = 0;

        //val = val + Speed;

        this.gameObject.transform.position = temP;
    }
}
