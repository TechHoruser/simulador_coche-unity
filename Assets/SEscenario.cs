using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SEscenario : MonoBehaviour
{
    float tamcam;
    float tamsuelo;
    
    int Esc;

    float medio;
    float poscam;
    string este_escenario;
    string otro_escenario;

    void Start()
    {
        Esc = 0;
        tamcam = GameObject.Find("suelo").GetComponent<BoxCollider2D>().bounds.size.x - 0.5f;
        tamsuelo = GameObject.Find("suelo").GetComponent<BoxCollider2D>().bounds.size.x;
    }

    void Update()
    {
        poscam = GameObject.Find("Camara").transform.position.x;

        if (Esc%2 == 0)
        {
            este_escenario = "Escenario1";
            otro_escenario = "Escenario2";
        }
        else
        {
            este_escenario = "Escenario2";
            otro_escenario = "Escenario1";
        }

        medio = GameObject.Find(este_escenario).transform.position.x;

        if (poscam + tamcam / 2 >= medio + tamsuelo / 2)
        {
            GameObject.Find(otro_escenario).transform.position = new Vector3(medio + tamsuelo, GameObject.Find(este_escenario).transform.position.y);
        }
        else if (poscam - tamcam / 2 <= medio - tamsuelo / 2)
        {
            GameObject.Find(otro_escenario).transform.position = new Vector3(medio - tamsuelo, GameObject.Find(este_escenario).transform.position.y);
        }

        if (poscam >= medio + tamsuelo / 2)
            Esc++;
        else if (poscam <= medio - tamsuelo / 2)
            Esc--;
    }
}
