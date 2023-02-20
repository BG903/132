using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour
{
    public Transform CircleTrans;
    public Transform Square1;
    public Transform Square2;   

    [Range(0,5)]
    public float Speed;
    


    void Update()
    {
        Square1.position = Vector3.Lerp(Square1.position,CircleTrans.position,Speed * Time.deltaTime);
        Square2.position = Vector3.Lerp(Square2.position,CircleTrans.position,Speed * Time.deltaTime);
        
        
    }
}
