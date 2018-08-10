using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour
{
    public float multiplier = 1;
    public float multipliermin;
    public float multipliermax;
    public float rotationSpeed;
    public float time;
    public Vector2 initialScale;
    float target = 1;
    public float speedchange;

    private void Start()
    {
        initialScale = transform.localScale;
        InvokeRepeating("change", time, time);
    }
    private void change()
    {
        target = Random.Range(multipliermin, multipliermax);
        
    }

    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed);
        multiplier = Mathf.Lerp(multiplier, target, Time.deltaTime * speedchange);
        transform.localScale = initialScale * multiplier;

    }
}
