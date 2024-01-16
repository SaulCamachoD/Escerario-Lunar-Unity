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

        // Calcular la dirección del movimiento
        Vector3 movementDirection = new Vector3(horizontalMovement, 0f, verticalMovement).normalized;

        // Calcular el vector de movimiento
        Vector3 movement = movementDirection * speed * Time.deltaTime;

        // Aplicar el movimiento al objeto
        transform.Translate(movement);
    }
}
