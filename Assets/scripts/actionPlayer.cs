using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class actionPlayer : MonoBehaviour
{
    public float speed = 5f;
    public float rotate = 150f;
    public Animator animator;
    private float x, y;

    
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0f,x * Time.deltaTime * rotate, 0f);
        transform.Translate(0f,0f, y * Time.deltaTime * speed);

        animator.SetFloat("VelX",x);
        animator.SetFloat("VelY",y);
    }
}
