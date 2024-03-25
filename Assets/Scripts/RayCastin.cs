using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastin : MonoBehaviour
{
    public GameObject crosshair;
    public GameObject projectilPrefab;
    public GameObject projectilInicio;
    public float projectilVelocidad;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }        
    }
    void Shoot()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, 1<<6))
        {
            GameObject ProjectilTemporal = Instantiate(projectilPrefab, projectilInicio.transform.position, Quaternion.identity);
            if(ProjectilTemporal.GetComponent<Proyectil>().GastarMana())
            {
                //ProjectilTemporal.transform.position = new Vector3(projectilInicio.transform.position.x, projectilInicio.transform.position.y + 3.5f, projectilInicio.transform.position.z);
                Vector3 direction = (hit.point - projectilInicio.transform.position).normalized;
                if (ProjectilTemporal.GetComponent<Rigidbody>()==null)
                {
                    ProjectilTemporal.AddComponent<Rigidbody>();
                }
                ProjectilTemporal.GetComponent<Rigidbody>().AddForce(direction * projectilVelocidad);
            } else
            {
                Destroy(ProjectilTemporal);
            }
            
            
        }
        UpdateCrosshairPosition(ray);
    }

    void UpdateCrosshairPosition(Ray ray)
    {
        crosshair.transform.position = ray.origin + ray.direction * 10f;
    }
}
