using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{

    static public GameObject target;


    void Update()
    {
        if (target) transform.LookAt(target.transform);
    }

}
