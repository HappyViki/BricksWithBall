using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupBricks : MonoBehaviour
{
    // Arbitrary number
    GameObject[] bricks = new GameObject[3];

    void Start()
    {
        setup();
    }

    public void setup()
    {
        // Arbitrary numbers, length matches bricks.Length
        int[] xs = {-5,0,5};

        // Create bricks, get them ready for game play
        for (int i = 0; i < bricks.Length; i++)
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = new Vector3(xs[i], 5, 0);
            cube.transform.localScale = new Vector3(3, 1, 1);
            cube.GetComponent<Collider>().isTrigger = true;
            cube.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            cube.AddComponent<RemoveBrick>();
            cube.AddComponent<UpdateScore>();

            bricks[i] = cube;
        }
    }
}
