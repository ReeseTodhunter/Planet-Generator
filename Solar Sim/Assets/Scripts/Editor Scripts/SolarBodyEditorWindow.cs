using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SolarBodyEditorWindow : EditorWindow
{
    [MenuItem("Tools/SolarBodyEditor")]
    public static void Open()
    {
        GetWindow<SolarBodyEditorWindow>();
    }

    public Transform systemRoot;

    private void OnGUI()
    {
        SerializedObject obj = new SerializedObject(this);

        EditorGUILayout.PropertyField(obj.FindProperty("systemRoot"));

        if (systemRoot == null)
        {
            EditorGUILayout.HelpBox("Root transform must be selected. Please assign a root transform", MessageType.Warning);
        }
        else;
        {
            EditorGUILayout.BeginVertical("box");
            DrawButtons();
            EditorGUILayout.EndVertical();
        }

        obj.ApplyModifiedProperties();
    }

    void DrawButtons()
    {
        if (GUILayout.Button("Create Central Solar Body"))
        {
            //CreateCentralBody();
        }
        if (Selection.activeGameObject != null && Selection.activeGameObject.GetComponent<SolarBody>())
        {
            if (GUILayout.Button("Add Orbiting Body"))
            {
                CreateOrbitingBody();
            }
            if (GUILayout.Button("Remove Body"))
            {
                RemoveBody();
            }
        }
    }

    void CreateCentralBody()
    {
        
    }

    void CreateOrbitingBody()
    {

    }
    
    void RemoveBody()
    {

    }
}