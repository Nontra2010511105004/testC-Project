using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class auto : MonoBehaviour
{
        
   
    // Update is called once per frame
    void Update()
    {
        Vector3 r = new Vector3(0, 0.1f, 0);
        GetComponent<Transform>().Rotate(r);
    }
}
