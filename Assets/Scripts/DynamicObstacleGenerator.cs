using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicObstacleGenerator : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public int numberOfObject;
    public Vector3 regionCenter;
    public float regionSizeX; // Tamaño en el eje X del plano
    public float regionSizeZ; // Tamaño en el eje Z del plano

    // Start is called before the first frame update
    void Start()
    {
       for (int i = 0; i < numberOfObject; i++)
        {
            // Genera posiciones aleatorias dentro de los límites definidos por regionSize
            Vector3 randomPosition = new Vector3(
                Random.Range(regionCenter.x-regionSizeX, regionCenter.x+regionSizeX),
                regionCenter.y, // Para mantenerlo en el plano, la coordenada Y debe ser 0
                Random.Range(regionCenter.z-regionSizeZ, regionCenter.z+regionSizeZ)
            );
            
            // Instancia el objeto en la posición aleatoria
            Instantiate(obstaclePrefab, randomPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
