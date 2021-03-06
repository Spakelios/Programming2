using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    void Start()
{
    CreateGold();
    
}

void CreateGold()
{
    

    
    Vector3[] vertices =
    {
        new Vector3(0, 0, 0),
        new Vector3(1, 0, 0),
        new Vector3(1, 2, 0),
        new Vector3(0, 2, 0),
        new Vector3(0, 2, 1),
        new Vector3(1, 2, 1),
        new Vector3(1, 0, 1),
        new Vector3(0, 0, 1),
    };

    int[] triangles =
    {
        0, 2, 1, //face front
        0, 3, 2,
        2, 3, 4, //face top
        2, 4, 5,
        1, 2, 5, //face right
        1, 5, 6,
        0, 7, 4, //face left
        0, 4, 3,
        5, 4, 7, //face back
        5, 7, 6,
        0, 6, 7, //face bottom
        0, 1, 6
    };
    
    
    Mesh mesh = GetComponent<MeshFilter>().mesh;
    // mesh.Clear ();
    mesh.vertices = vertices;
    mesh.triangles = triangles;
    mesh.Optimize ();
    mesh.RecalculateNormals();
   
    BoxCollider bc = gameObject.AddComponent(typeof(BoxCollider)) as BoxCollider; //adds a box collider to the object
    bc.isTrigger = true; //sets the collider to trigger
  

}
}

