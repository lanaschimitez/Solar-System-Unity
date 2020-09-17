using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addForce : MonoBehaviour
{
    public Vector3 startForce;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(startForce);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
