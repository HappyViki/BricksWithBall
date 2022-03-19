using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateScore : Score
{
    void OnTriggerEnter(Collider col)
    {
        UpdateScore();
    }
}
