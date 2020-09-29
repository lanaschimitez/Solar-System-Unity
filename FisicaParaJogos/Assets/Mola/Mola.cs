using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mola : MonoBehaviour
{
    public Vector3 forca; //força aplicada sobre o corpo elástico
    public float K; //constante elástica 
    public Vector3 deformação; //comprimento final da mola - comprimento inicial.
    public float amortecimento;
    public Vector3 velocidade;

    public Vector3 posicaoInicial;
    public Vector3 posicaoFinal;
    public Rigidbody bodyCaixa;

    public Vector3 aceleracao;

    public bool ativar;
    void Start()
    {
        bodyCaixa = gameObject.GetComponent<Rigidbody>();
        posicaoInicial = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        posicaoFinal = transform.position;
        deformação = posicaoFinal - posicaoInicial;
        forca = (-K * deformação) - amortecimento * velocidade; 
        aceleracao = forca / bodyCaixa.mass;
        velocidade += (aceleracao * Time.deltaTime);
        transform.position = transform.position + velocidade * Time.deltaTime + (aceleracao * (Time.deltaTime * Time.deltaTime)) / 2;
    }
}
