using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float sensibilidad = 300f;//sensibilidad del mouse
    //varibles de retorno
    private Vector2 entradaAngulos;//girar abajo arriba izquierda derecha con el mouse
    private Vector2 angulos;//gira el persona y la camara

    public Vector2 limitesCamara;
    // Start is called before the first frame update
    //void Start()
    //{
    //}
    // Update is called once per frame
    void Update()
    {
        entradaAngulos = new Vector2(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X")) * Time.deltaTime;

        angulos.x -= entradaAngulos.x * sensibilidad;
        angulos.y += entradaAngulos.y * sensibilidad;

        angulos.x = Mathf.Clamp(angulos.x, limitesCamara.x, limitesCamara.y);

        transform.localRotation = Quaternion.Euler(angulos.x, angulos.y, 0f);
    }
}
