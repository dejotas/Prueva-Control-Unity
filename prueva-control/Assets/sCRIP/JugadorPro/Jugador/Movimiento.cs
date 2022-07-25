using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public Animator anim;
    public Transform camara;

    private float referenciaSmooth;
    private float smoothAngulo = 20f;


    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    void Update()
    {
        Caminar();
        Correr();
    }

    void Caminar()
    {
        Vector3 direccion = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")).normalized;
        Vector3 inputDirec = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

        if (direccion.magnitude > 0.1f)
        {
            float medirAngulo = Mathf.Atan2(direccion.x, direccion.z) * Mathf.Rad2Deg + camara.eulerAngles.y;
            float angulo = Mathf.SmoothDampAngle(transform.eulerAngles.y, medirAngulo, ref referenciaSmooth, smoothAngulo * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0f, angulo, 0f);
            anim.SetFloat("Mag", inputDirec.magnitude);
            Saltar();
        }
    }
   void Correr()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            anim.SetBool("Run", true);
        }
        else
        {
            anim.SetBool("Run", false);
        }
    }
    void Saltar()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("Jump");
        }
    }
        
}
