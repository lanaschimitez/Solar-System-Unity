using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetaScript1 : MonoBehaviour
{
    public float d;
    Vector3 forca;
    public GameObject planeta;
    public Rigidbody bodyPlaneta;
    public Vector3 velocidade;
    private Vector3 posicaoPlaneta;
    private Vector3 posicaoLua;
    public Vector3 r;
    public GameObject lua;
    public Rigidbody bodyLua;

    public void Start()
    {
        bodyPlaneta = planeta.GetComponent<Rigidbody>();
        bodyLua = planeta.GetComponent<Rigidbody>();
    }

    public void Update()
    {
        posicaoLua = transform.position;

        posicaoPlaneta = planeta.transform.position;
        r.x = Mathf.Pow(posicaoLua.x - posicaoPlaneta.x, 2);
        r.y = Mathf.Pow(posicaoLua.y - posicaoPlaneta.y, 2);
        r.z = Mathf.Pow(posicaoLua.z - posicaoPlaneta.z, 2);

        forca = - (posicaoLua - posicaoPlaneta) * ((d * bodyPlaneta.mass * bodyLua.mass) / (Mathf.Pow(Mathf.Sqrt(r.x + r.y + r.z), 3)));
        velocidade += forca / bodyLua.mass * Time.deltaTime;
        transform.position = transform.position + velocidade * Time.deltaTime;
    }


}
