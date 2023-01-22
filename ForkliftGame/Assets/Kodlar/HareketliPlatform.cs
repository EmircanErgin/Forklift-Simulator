 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HareketliPlatform : MonoBehaviour
{
    public GameObject Forklift;

    private void OnTriggerEnter(Collider other)
    {
        Forklift.transform.parent = transform;
    }

    private void OnTriggerExit(Collider other)
    {
        Forklift.transform.parent = null;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
