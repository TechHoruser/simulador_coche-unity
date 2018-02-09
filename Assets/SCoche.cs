using UnityEngine;
using System.Collections;

public class SCoche : MonoBehaviour {
    public Vector3 velocidad = Vector3.zero;
    public Vector3 velocidadGas;
    public Vector3 velocidadFreno;
    public float velocidadMaxima;
    public float velocidadMinima;
   // SRueda derecha = (SRueda)GameObject.Find("ruedaD").GetComponent("SRueda");
    void Start () {
        velocidadGas.x = 0.3f;
        velocidadFreno.x = -0.3f;
        velocidadMaxima = 15;
        velocidadMinima = -15;
    }

    void Update()
    {
    }

    void FixedUpdate()
    {
        GameObject.Find("Camara").transform.position = new Vector3(transform.position.x, GameObject.Find("Camara").transform.position.y);
    }
}
  