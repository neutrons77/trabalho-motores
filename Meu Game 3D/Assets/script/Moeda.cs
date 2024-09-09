using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moeda : MonoBehaviour
{
    
    public int velocidadedeGiro = 50;
    
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        throw new NotImplementedException();
    }


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * velocidadedeGiro * Time.deltaTime, Space.World);
    }
}
