using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaracontrolle : MonoBehaviour
{

    private Vector3 Desplazamiento = new Vector3(-3, 2, 1);
    public GameObject Jugador;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Jugador.transform.position + Desplazamiento;
    }
}
