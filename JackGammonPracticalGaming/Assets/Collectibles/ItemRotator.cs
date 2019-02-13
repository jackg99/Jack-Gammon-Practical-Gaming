using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class ItemRotator : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 125) * Time.deltaTime);
    }
}



