using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    public float xVelocidad, LimiteDerecha, LImiteIzquierda;
    bool Derecha;
    public GameObject Cilindro, Esfera, baseizquierda, basederecha;

    void Start()
    {
        Derecha = true;
    }

    void Update()
    {
        if (Derecha)
        {
            transform.position += new Vector3(xVelocidad, 0, 0);
        }

        else
        {
            transform.position -= new Vector3(xVelocidad, 0, 0);
        }

        if (transform.position.x >= LimiteDerecha)
        {
            Derecha = false;
            GameObject clon = Instantiate(Cilindro);
            clon.transform.position = basederecha.transform.position + new Vector3(0, 1, 0);
        }

        else if (transform.position.x <= LImiteIzquierda)
        {
            Derecha = true;
            GameObject clon = Instantiate(Esfera);
            clon.transform.position = baseizquierda.transform.position + new Vector3(0, 1, 0); 
            
        }
    }
}
