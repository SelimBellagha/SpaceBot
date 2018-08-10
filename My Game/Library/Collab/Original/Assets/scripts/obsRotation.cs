using UnityEngine;

public class obsRotation : MonoBehaviour
{
    public Transform obs;
    Transform Planet;
    public float dist;
    public float speed;
    private void Start()
    {
        Planet = GameObject.FindGameObjectWithTag("planet").transform;
    }
    private void Update()
    {
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
        obs.localPosition = new Vector3(Planet.localScale.x / 2 + dist, 0, 0);
    }

}
