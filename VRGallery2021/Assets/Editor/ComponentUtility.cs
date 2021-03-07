using UnityEditor;
using UnityEngine;
 
public static class ComponentUtility
{
    [MenuItem("CONTEXT/Component/Duplicate Component")]
    private static void DuplicateComponent(MenuCommand menuCommand)
    {
        DuplicateComponent(menuCommand.context as Component);
    }
 
    public static void DuplicateComponent(Component component)
    {
        if (component == null)
            return;
 
        var attributes = component.GetType().GetCustomAttributes(true);
        foreach (var attr in attributes)
            Debug.Log(attr);
 
        UnityEditorInternal.ComponentUtility.CopyComponent(component);
        UnityEditorInternal.ComponentUtility.PasteComponentAsNew(component.gameObject);
    }
}