using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraTakip : MonoBehaviour
{
    public Transform Forklift;
    void Start()
    {

    }
    void LateUpdate()
    {
        
    }

    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, Forklift.transform.position, 0.3f);
    }
    
}
