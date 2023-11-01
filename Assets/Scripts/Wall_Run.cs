using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_Run : MonoBehaviour
{
    [SerializeField] private float xAxis;
    [SerializeField] private float zAxis;
    private void Start()
    {
        transform.Rotate(xAxis, 0, zAxis);
    }
}
