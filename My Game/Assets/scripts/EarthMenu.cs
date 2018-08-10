using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthMenu : MonoBehaviour
{
    public float rotationSpeed;
    public float time;
    public Vector2 initialScale;

    private void Start()
    {
        initialScale = transform.localScale;
    }

    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed);
    }
}
