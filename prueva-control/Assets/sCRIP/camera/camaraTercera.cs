using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaraTercera : MonoBehaviour
{

    public float sensibilidad = 300f;
    private Vector2 entradaAngulos;
    private Vector2 angulo;

    public Vector2 limitesCamara;
    // Start is called before the first frame update
    void Start()
    {       
    }
    // Update is called once per frame
    void Update()
    {
        entradaAngulos = new Vector2(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X")) * Time.deltaTime;

        angulo.x -= entradaAngulos.x * sensibilidad;
        angulo.y += entradaAngulos.y * sensibilidad;

        angulo.x = Mathf.Clamp(angulo.x, limitesCamara.x, limitesCamara.y);
        transform.localRotation = Quaternion.Euler(angulo.x, angulo.y, 0f);
    }
}
