using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;


[CustomEditor(typeof(AsteroidType))]
public class AsteroidTypeEditor : Editor
{
    public VisualTreeAsset uxml;
    
    public override VisualElement CreateInspectorGUI()
    {
        var root = new VisualElement();
        AsteroidType myScript = (AsteroidType)target;
        uxml.CloneTree(root);
        
        return root;
    }
}
