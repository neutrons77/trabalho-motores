using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int velocidade = 10;
    private Rigidbody rb;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("START");
        TryGetComponent(out rb);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("UPDATE");
        float h = input.GetAxis("Horizontal"); //-1 esquerda, 0 nada, 1 direita
        float v = input.GetAxis("Vertical"); //-1 pra tras, 0 nada, 1 pra frente

        vector3 direcao = new vector3(h, 0, v);
        rb.AddForce(direcao * velocidade * Time.deltaTime, ForceMode.Impulse);




    }
}






