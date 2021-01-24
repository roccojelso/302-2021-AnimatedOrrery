using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Lerpy))]
public class LerpDemoEditor : Editor
{

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        Lerpy lerper = (Lerpy)target;

        if (GUILayout.Button("PLAY"))
        {

            lerper.PlayTweenAnim();

        }

    }

}