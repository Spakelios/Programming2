using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeshLabwork2_Scene2 : MonoBehaviour
{

    public float scale;
    public float waveSpeed;
    public float waveHeight;
    public Slider slide;
 
    private void Update()
    {
        CalcNoise();
    }

    public void Start()
    {
        speedwagon();
    }

    void CalcNoise()
    {
        MeshFilter mf = GetComponent<MeshFilter>();
        Vector3[] verts = mf.mesh.vertices;

        for (int i = 0; i < verts.Length; i++)
        {
            float px = (verts[1].x * scale) + (Time.time * waveSpeed);
            float pz = (verts[1].z * scale) + (Time.time * waveSpeed);

            verts[1].y = Mathf.PerlinNoise(px, pz) * waveHeight;
        }

        mf.mesh.vertices = verts;
        mf.mesh.RecalculateNormals();
        mf.mesh.RecalculateBounds();
    }

  public void speedwagon()
  {
      waveSpeed = slide.value * 100f;
  }

}

