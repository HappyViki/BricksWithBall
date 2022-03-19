using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetGame : MonoBehaviour
{
    GameObject player;
    GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        ball = GameObject.Find("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.transform.position.y < -10f) {
            player.transform.position = new Vector3(0, 0, 0);
            ball.transform.position = new Vector3(0, 3, 0);
            ball.GetComponent<Rigidbody>().velocity = new Vector3(0f,0f,0f); 

            GameObject.Find("Bricks").GetComponent<SetupBricks>().setup();
        }
    }
}
