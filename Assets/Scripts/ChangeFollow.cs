using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeFollow : MonoBehaviour
{
    public GameObject target;

    void Start()
    {
        if (target == null)
        {
            target = this.gameObject;
        }
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        Follow.target = target;

        Camera.main.fieldOfView = Mathf.Clamp(60 * target.transform.localScale.x, 1, 100);

    }
}
