using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody m_Body;
    public Vector3 forca1;
    public Vector3 forca2;
    public Vector3 forca3;
    public Vector3 soma;
    public Vector3 velocidade, aceleração;

    void Start()
    {
        m_Body = GetComponent<Rigidbody>();       
    }

    // Update is called once per frame
    void Update()
    {
        //m_Body.AddForce(Vector3.up * forca1 * Time.fixedDeltaTime, ForceMode.VelocityChange);
        //m_Body.AddForce(Vector3.left * forca2 * Time.fixedDeltaTime, ForceMode.VelocityChange);
        //m_Body.AddForce(Vector3.right * forca3 * Time.fixedDeltaTime, ForceMode.VelocityChange);
        //m_Body.AddForce(Vector3.down * forca4 * Time.fixedDeltaTime, ForceMode.VelocityChange);

        soma = (forca1 + forca2 + forca3) / m_Body.mass;

    }
    private void FixedUpdate()
    {
        velocidade = velocidade + soma * Time.deltaTime;

        CalculoPosicao();
    }
    void CalculoPosicao()
    {
        transform.position = transform.position + velocidade * Time.deltaTime + ((soma * (Time.deltaTime * Time.deltaTime)) / 2);
    }

    
}

