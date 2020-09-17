using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VermelhoScript : MonoBehaviour
{
    public Vector3 velocidade, aceleração;

    private void Start()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(10, 0, 0);
    }

    private void FixedUpdate()
    {
        velocidade = velocidade + aceleração * Time.deltaTime;

        CalculoPosicao();
    }

    void CalculoPosicao()
    {
        transform.position = transform.position + velocidade * Time.deltaTime + (aceleração * (Time.deltaTime * Time.deltaTime)) / 2;
    }

}
