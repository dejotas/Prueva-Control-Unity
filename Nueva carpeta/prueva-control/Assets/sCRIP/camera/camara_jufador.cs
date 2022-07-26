using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class camara_jufador : MonoBehaviour
{
    //public GameObject Jugador;
    public Vector3 offset;
    private Transform target;
    [Range(0, 1)] public float lerpValue;
    public float sensibilidad;

    void Start()
    {
        target = GameObject.Find("Clark").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + offset, lerpValue);
        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * sensibilidad, Vector3.up) * offset;

        transform.LookAt(target);
    }
}