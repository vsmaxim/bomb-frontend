using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFieldManager : MonoBehaviour
{
    public int cellWidth;

    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = GetComponent<MeshFilter>().sharedMesh;

        float xSize = mesh.bounds.size.x;
        float zSize = mesh.bounds.size.z;
        float scaleFactor = xSize / cellWidth;

        Vector3 cubeScale = Vector3.one * scaleFactor;
        Vector3 startPoint = new Vector3((-xSize + scaleFactor) / 2, scaleFactor / 2, (-zSize + scaleFactor) / 2);
        
        for (int i = 1; i < cellWidth - 1; i += 2)
        {
            for (int j = 1; j < cellWidth - 1; j += 2)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.parent = transform;
                cube.transform.localScale = cubeScale;
                cube.transform.localPosition = new Vector3(startPoint.x + i * scaleFactor, startPoint.y, startPoint.z + j * scaleFactor); 
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
