using UnityEngine;
using System.Collections;

public class SRueda : MonoBehaviour
{

    bool gas = false;
    bool freno = false;
    GameObject obj;
    SCoche coche;
    float rozamiento = -0.1f;

    void Start()
    {
         obj = GameObject.Find("Coche");
        coche = obj.GetComponent<SCoche>();
    }

    void Update()
    {

    }

    void OnCollisionStay2D(Collision2D col)
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gas = true;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            freno = true;
        }
    }

    void FixedUpdate()
    {
        if (gas == true)
        {
            gas = false;
            coche.velocidad.x += coche.velocidadGas.x;
        }

        if (freno == true)
        {
            freno = false;
            coche.velocidad.x += coche.velocidadFreno.x;
        }
        if (coche.velocidad.x > 0)
            coche.velocidad.x += rozamiento;
        else
        {
            if (coche.velocidad.x != 0)
                coche.velocidad.x -= rozamiento;
        }
        if (coche.velocidad.x > coche.velocidadMaxima) coche.velocidad.x = coche.velocidadMaxima;
        if (coche.velocidad.x < -coche.velocidadMaxima) coche.velocidad.x = -coche.velocidadMaxima;
        GameObject.Find("Coche").transform.position += coche.velocidad * Time.deltaTime;
    }
}
