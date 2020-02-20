using UnityEngine;

public class UseForce : MonoBehaviour
{
    public float Force = 1.0f;
    public Rigidbody RigBod;

    void Start()
    {
        RigBod = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        RigBod.AddForce(transform.forward * Force);
    }
}