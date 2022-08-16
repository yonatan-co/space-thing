using UnityEditor;
using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;

public class RandomTerrain : MonoBehaviour
{
    public Terrain terrain;
    public TerrainData terrainData;
    public Vector2 randomHeightRange = new Vector2(0,0.1f);

    public float perlinXScale = 0.01f;
    public float perlinYScale = 0.01f;
    public int perlinOffsetX = 0;
    public int perlinOffsetY = 0;
    public int perlinOctaves = 3;
    public float perlinPersistance = 8;
    public float perlinHeightScale = 0.09f;
    public bool resetTerrain = true;

    void Start()
    {
        terrain = this.GetComponent<Terrain>();
        terrainData = Terrain.activeTerrain.terrainData;
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown("space"))
        {
            Perlin();
        }

    }


    public void RanTerrain()
    {
        float[,] heightMap = GetHeightMap();

        for (int x = 0; x < terrainData.heightmapResolution; x++)
        {
            for (int z = 0; z < terrainData.heightmapResolution; z++)
            {
                heightMap[x, z] += UnityEngine.Random.Range(randomHeightRange.x, randomHeightRange.y);
            }
        }
        terrainData.SetHeights(0, 0, heightMap);
    
    }

    float[,] GetHeightMap()
    {
        if (!resetTerrain)
        {
            return terrainData.GetHeights(0, 0, terrainData.heightmapResolution,
                                                terrainData.heightmapResolution);
        }
        else
            return new float[terrainData.heightmapResolution,
                             terrainData.heightmapResolution];
            
    }

    public void Perlin()
    {
        float[,] heightMap = GetHeightMap();

        for (int y = 0; y < terrainData.heightmapResolution; y++)
        {
            for (int x = 0; x < terrainData.heightmapResolution; x++)
            {
                heightMap[x, y] += fBM((x+perlinOffsetX) * perlinXScale, 
                                            (y+perlinOffsetY) * perlinYScale, 
                                            perlinOctaves, 
                                            perlinPersistance) * perlinHeightScale;
            }
        }

        terrainData.SetHeights(0, 0, heightMap);
    }

    public static float fBM(float x, float y, int oct, float persistance)
    {
        float total = 0;
        float frequency = 1;
        float amplitude = 1;
        float maxValue = 0;
        for (int i = 0; i < oct; i++)
        {
            total += Mathf.PerlinNoise(x * frequency, y * frequency) * amplitude;
            maxValue += amplitude;
            amplitude *= persistance;
            frequency *= 2;
        }

        return total / maxValue;
    }
}
