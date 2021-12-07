using System;
using System.Collections.Generic;
using UnityEngine;

public class Mesh2_Scene2 : MonoBehaviour
{
    public float meshWidth = 10f;
    public float meshHeight = 10f ;

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

        Vector3[] normals = new Vector3[4];
        normals[0] = -Vector3.forward;
        normals[1] = -Vector3.forward;
        normals[2] = -Vector3.forward;
        normals[3] = -Vector3.forward;

        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.normals = normals;
    }

    private void Update()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        Vector3[] vertices = mesh.vertices;
        Vector3[] normals = mesh.normals;
        int i = 0;

        while (i < vertices.Length)
        {
            vertices[i] += normals[i] * Mathf.Sin(Time.time);
            i++;
        }

        mesh.vertices = vertices;
        {
            
        }
    }
}

