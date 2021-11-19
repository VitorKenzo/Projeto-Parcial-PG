using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changePersp : MonoBehaviour
{

    public Camera adjustCamera;
    public Camera adjustCamera2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)){
            adjustCamera.orthographic = !adjustCamera.orthographic;
            adjustCamera2.orthographic = !adjustCamera2.orthographic;
        }
        
    }
}
