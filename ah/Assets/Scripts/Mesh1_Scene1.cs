using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mesh1_Scene1 : MonoBehaviour
{
    public float meshWidth ;
    public float meshHeight ;

    void Start()
    {
        MeshFilter mf = GetComponent<MeshFilter>();
        Mesh mesh = new Mesh();
        mf.mesh = mesh;

        Vector3[] vertices = new Vector3[4]
        {

            new Vector3(0, 0, 0), new Vector3(meshWidth, 0, 0), new Vector3(0, meshHeight, 0),
            new Vector3(meshWidth, meshHeight, 0)
        };

        int[] triangles = new int[6];
        triangles[0] = 0;
        triangles[1] = 2;
        triangles[2] = 1;

        triangles[3] = 2;
        triangles[4] = 3;
        triangles[5] = 1;

        mesh.vertices = vertices;
        mesh.triangles = triangles;

    }
}