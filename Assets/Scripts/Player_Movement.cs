using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] private float move_Speed;
    [SerializeField] private bool is_Grounded;

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
            transform.Translate(Vector3.right * move_Speed);
        }
    }
}
