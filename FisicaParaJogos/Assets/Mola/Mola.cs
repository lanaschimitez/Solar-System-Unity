﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mola : MonoBehaviour
{
    public Vector3 forca; //força aplicada sobre o corpo elástico
    public float K; //constante elástica 
    public Vector3 deformação; //comprimento final da mola - comprimento inicial.
    public Vector3 amortecimento;
    public Vector3 velocidade;

    public Vector3 posicaoInicial;
    public Vector3 posicaoFinal;

    public GameObject caixa;
    public Rigidbody bodyCaixa;

    public Vector3 nulo;

    public bool ativar;
    void Start()
    {
        bodyCaixa = gameObject.GetComponent<Rigidbody>();
        posicaoInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        posicaoFinal = transform.position;
        if (!ativar) return;
        deformação = posicaoFinal - posicaoInicial;
        forca = -K * deformação;
        // modificacao de posicao por forcas externas, forca/massa =  aceleracao
        // acelaracao = velocidade

    //usar um dos primeiros script
        //transform.position = transform.position + forca * Time.deltaTime;
        if(deformação == nulo)
        {
            ativar = false;
        }

    }
}
