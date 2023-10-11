using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] private float move_Speed;
    [SerializeField] private float gravity_Modifier;
    [SerializeField] private bool is_Grounded;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            is_Grounded = true;
        }
    }
    void Update()
    {
        if(is_Grounded == true)
        {
            transform.Translate(Vector3.up * move_Speed);
            if (Input.GetButtonDown("Jump"))
            {
                Physics.gravity *= -1;
            }
        }
    }
}
