using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class actionPlayer : MonoBehaviour
{
    public float normalSpeed = 5f;
    public float sprintSpeed = 30f;
    public float rotate = 150f;
    public Animator animator;
    private float x, y;
    private Rigidbody rb;
    private float speed; // Mover la declaración de speed fuera del bloque if-else

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speed = normalSpeed; // Inicializar la velocidad normal al inicio
    }

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        Vector3 Movement = new Vector3(x, 0f, y);

        if (Input.GetKey(KeyCode.Space))
        {
            speed = sprintSpeed;
            animator.SetBool("Sprint", true);
        }
        else
        {
            speed = normalSpeed;
            animator.SetBool("Sprint", false);
        }

        rb.AddForce(Movement * speed);

        animator.SetFloat("VelX", x);
        animator.SetFloat("VelY", y);

        float rotacion = Input.GetAxis("Mouse X") * rotate * Time.deltaTime;
        transform.Rotate(Vector3.up * rotacion);
    }
}

    

