using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleRotate : MonoBehaviour
{
    //Transform rotateZ = transform.rotation.z;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        RotatePaddles();
        //Debug.Log(Mathf.Sin(Time.time /10) * 45); 
    }




    void RotatePaddles()
    {
        transform.rotation = Quaternion.Euler(0, 0f, Mathf.Sin(Time.time / .5f) * 45);
        //Debug.Log("z: " + gameObject.transform.localEulerAngles.z);
        //if (gameObject.transform.localEulerAngles.z == 45)
        //{
        //  transform.Rotate(0, 0, .2f);
        //}
        //else if(gameObject.transform.localEulerAngles.z >= -45)
        //{
        //transform.Rotate(0, 0, .2f);
        //}

    }



}
