using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class HeavenlyBody : MonoBehaviour
{
    public float mass;
    public Vector3 velocity;
    List<HeavenlyBody> bodies;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bodies = new List<HeavenlyBody>();
        bodies = GameObject.FindObjectsByType<HeavenlyBody>(FindObjectsSortMode.None).ToList();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 netForce = Vector3.zero;
        float G = 5f;
        foreach(var body in bodies)
        {
            if (body != this)
            {
                Vector3 r = body.transform.position - transform.position;
                Vector3 F = mass * body.mass / (r.magnitude * r.magnitude) * r.normalized;

                netForce += F;
            }
        }
        Vector3 a = netForce / mass;
        velocity += a * Time.fixedDeltaTime;
        transform.Translate(velocity * Time.fixedDeltaTime);
    }
}
