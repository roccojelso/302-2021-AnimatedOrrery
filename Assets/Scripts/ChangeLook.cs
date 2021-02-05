using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLook : MonoBehaviour
{
    public GameObject target;


    void OnMouseDown()
    {
        Look.target = target;

        Camera.main.fieldOfView = Mathf.Clamp(60 * target.transform.localScale.x, 1, 100);

    }
}
