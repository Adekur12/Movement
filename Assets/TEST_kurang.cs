using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST_kurang : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fillbar.instance.kurang(50);
        }
    }
}
