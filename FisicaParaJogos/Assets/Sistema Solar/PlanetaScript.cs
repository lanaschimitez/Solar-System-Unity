using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetaScript : MonoBehaviour
{
    public Vector3 center;
    public Transform focus1;
    public float d;
    Vector3 forca;
    public GameObject sun;
    public Rigidbody bodySun;
    public Rigidbody bodyPlanet;
    public Vector3 velocidade;
    Vector3 posicaoInicial;

    public void Start()
    {
        bodySun = sun.GetComponent<Rigidbody>();
        bodyPlanet = this.GetComponent<Rigidbody>();
        posicaoInicial = transform.position;
    }

    public void Update()
    {
        forca = -transform.position * ((d * bodySun.mass * bodyPlanet.mass) / (Mathf.Pow(Mathf.Sqrt((transform.position.x * transform.position.x) + (transform.position.y * transform.position.y) + (transform.position.z * transform.position.z)), 3)));

        transform.position = transform.position + velocidade*Time.deltaTime;

        velocidade += forca/bodyPlanet.mass*Time.deltaTime;

    }


}
