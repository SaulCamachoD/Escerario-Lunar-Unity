using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionSoldier : MonoBehaviour
{
    public float speed = 5f;
    
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        // Calcular la direcci�n del movimiento
        Vector3 movementDirection = new Vector3(horizontalMovement, 0f, verticalMovement).normalized;

        if (movementDirection != Vector3.zero)
        {
            // Calcular la rotaci�n hacia la direcci�n del movimiento
            Quaternion rotacionDeseada = Quaternion.LookRotation(movementDirection, Vector3.up);

            // Aplicar la rotaci�n gradualmente
            transform.rotation = Quaternion.Slerp(transform.rotation, rotacionDeseada, 0.15f);
        }

        // Calcular el vector de movimiento
        Vector3 movimiento = movementDirection * speed * Time.deltaTime;

        // Aplicar el movimiento al objeto
        transform.Translate(movimiento);
    }
}
