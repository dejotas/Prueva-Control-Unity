using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Clarkcontroller : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotationSpeed = 100.0f;
    private Animator animator;
    private Rigidbody Animator;

    //public float jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
        Animator = GetComponent<Rigidbody>();
        

    }
    // Update is called once per frame
    //actulizacion la posicion del persona
    void Update()
    
    {
        
        float tanslation = Input.GetAxis("Vertical");
        float rotation = Input.GetAxis("Horizontal");

        float desplazamiento = tanslation * speed * Time.deltaTime;
        float rotacion = rotation * rotationSpeed * Time.deltaTime;
        

        //Detener al personaje

        if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow)||
            Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            animator.SetBool("Correr", false);
        }
        ////saltar
        //public void PlayerSkills()
        //{
        //    if (animator.isGrounded && Input.GetButtonDown("Jump"))
        //    {
        //        fallVelocity = jumpForce;
        //        movePlayer.y = fallVelocity;
        //    }
        //}


        //Correr hacia adelante y hacia atras   

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            animator.SetBool("Correr", true);
            transform.Translate(0, 0, desplazamiento);
        }
        //girar a la izquierda o a la derecha
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, rotacion, 0);
        }
        
        if (Input.GetKey(KeyCode.Space))
        {
            Animator.AddForce(Vector3.up * 10, ForceMode.Impulse);
        }

    }
}



