using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lorenz : MonoBehaviour
{
    public float sigma,rho,betha;
    void Start()
    {
        //transform.position = new Vector3(
        //    Random.Range(-1,2),
        //    Random.Range(-1,2),
        //    Random.Range(-1,2)
        //);
    }

    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        transform.position = transform.position + lorenz(transform.position, sigma, rho, betha, 0.01f);
    }
    private void LateUpdate()
    {
        Camera.main.transform.LookAt(transform.position);
    }

    public Vector3 lorenz(Vector3 pos, float sigma,float rho, float betha,float dt)
    {
        float dx, dy, dz;
        dx = sigma * (pos.y - pos.x);
        dy = pos.x * (rho - pos.z) - pos.y;
        dz = pos.x * pos.y - betha * pos.z;
        return new Vector3(dx,dy,dz) * dt;
    }
}
