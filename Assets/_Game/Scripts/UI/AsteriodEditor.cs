using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

#if true

[CustomPropertyDrawer(typeof(AsteriodEditor))]

public class AsteriodEditor : PropertyDrawer
{
    
    public override VisualElement CreatePropertyGUI(SerializedProperty property)
    {
        return new PropertyField(property);
    }
    
    
}

#endif

