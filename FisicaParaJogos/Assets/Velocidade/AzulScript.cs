using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AzulScript : MonoBehaviour
{
    public Vector3 acelerecao, velocidade;    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        velocidade = velocidade + acelerecao * Time.deltaTime;

        transform.position = transform.position + velocidade * Time.deltaTime;
    }
}
