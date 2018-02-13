using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtGenerator : MonoBehaviour {
    
    public GameObject dirt, grassDirt;

    const float DIRT_SIZE = 1.28f;
    const float MAX_WALL_BOUND_X = 8.96f;
    const float MAX_WALL_BOUND_Y = 5.12f;
    const float MAX_FLOOR_BOUND_X = 2.56f;
    const float FLOOR_Y = -4.48f;
    const int NUM_CELL_X = 5;
    const int NUM_CELL_Y = 9;
    const int NUM_CELL_FLOOR = 5;

    // Use this for initialization
    void Start () {
        GenerateWall();
        GenerateFloor();
    }

    void GenerateWall()
    {
        for (int i = 0; i < NUM_CELL_Y; i++)
        {
            float y = MAX_WALL_BOUND_Y - DIRT_SIZE * i;
            GenerateWallX(true, y);
            GenerateWallX(false, y);
        }
    }

	void GenerateWallX(bool isNegative, float y)
    {
        int sign = isNegative ? -1 : 1;
        for (int i = 0; i < NUM_CELL_X; i++)
        {
            float x = sign*(MAX_WALL_BOUND_X - DIRT_SIZE * i);
            Instantiate(dirt, new Vector2(x, y), Quaternion.identity, transform);
        }
    }

    void GenerateFloor()
    {
        for (int i = 0; i < NUM_CELL_FLOOR; i++)
        {
            float x = MAX_FLOOR_BOUND_X - i * DIRT_SIZE;
            Instantiate(grassDirt, new Vector2(x, FLOOR_Y), Quaternion.identity, transform);
        }
    }
}
