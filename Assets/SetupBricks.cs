using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupBricks : MonoBehaviour
{
    GameObject[] bricks = new GameObject[3];

    // Start is called before the first frame update
    void Start()
    {
        setup();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void setup()
    {
        int[] xs = {-5,0,5};

        for (int i = 0; i < bricks.Length; i++)
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = new Vector3(xs[i], 5, 0);
            cube.transform.localScale = new Vector3(3, 1, 1);
            cube.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            cube.AddComponent<RemoveBrick>();

            bricks[i] = cube;
        }
    }
}
