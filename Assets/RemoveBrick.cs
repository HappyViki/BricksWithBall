using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBrick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Collider>().isTrigger = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        Score score = GameObject.Find("/Canvas/Score").GetComponent<Score>();
        score.UpdateScore();
        Destroy(this.gameObject);
    }
}
