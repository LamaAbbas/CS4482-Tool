using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Tab))]
public class TabEditor : Editor {

    private Tab myTarget;

    private SerializedObject SOTarget;

    private SerializedProperty stringVar1;
    private SerializedProperty stringVar2;
    private SerializedProperty stringVar3;
    private SerializedProperty stringVar4;
    private SerializedProperty stringVar5;

    private SerializedProperty intVar1;
    private SerializedProperty intVar2;
    private SerializedProperty intVar3;
    private SerializedProperty intVar4;
    private SerializedProperty intVar5;

    private SerializedProperty boolVar1;
    private SerializedProperty boolVar2;
    private SerializedProperty boolVar3;
    private SerializedProperty boolVar4;
    private SerializedProperty boolVar5;

    private SerializedProperty listVar1;
    private SerializedProperty listVar2;
    private SerializedProperty listVar3;
    private SerializedProperty listVar4;
    private SerializedProperty listVar5;

    private SerializedProperty arrayVar1;
    private SerializedProperty arrayVar2;
    private SerializedProperty arrayVar3;
    private SerializedProperty arrayVar4;
    private SerializedProperty arrayVar5;

    private void OnEnable() {
        myTarget = (Tab)target;
        SOTarget = new SerializedObject(target);

        stringVar1 = SOTarget.FindProperty("stringVar1");
        stringVar2 = SOTarget.FindProperty("stringVar2");
        stringVar3 = SOTarget.FindProperty("stringVar3");
        stringVar4 = SOTarget.FindProperty("stringVar4");
        stringVar5 = SOTarget.FindProperty("stringVar5");

        intVar1 = SOTarget.FindProperty("intVar1");
        intVar2 = SOTarget.FindProperty("intVar2");
        intVar3 = SOTarget.FindProperty("intVar3");
        intVar4 = SOTarget.FindProperty("intVar4");
        intVar5 = SOTarget.FindProperty("intVar5");

        boolVar1 = SOTarget.FindProperty("boolVar1");
        boolVar2 = SOTarget.FindProperty("boolVar2");
        boolVar3 = SOTarget.FindProperty("boolVar3");
        boolVar4 = SOTarget.FindProperty("boolVar4");
        boolVar5 = SOTarget.FindProperty("boolVar5");

        listVar1 = SOTarget.FindProperty("listVar1");
        listVar2 = SOTarget.FindProperty("listVar2");
        listVar3 = SOTarget.FindProperty("listVar3");
        listVar4 = SOTarget.FindProperty("listVar4");
        listVar5 = SOTarget.FindProperty("listVar5");

        arrayVar1 = SOTarget.FindProperty("arrayVar1");
        arrayVar2 = SOTarget.FindProperty("arrayVar2");
        arrayVar3 = SOTarget.FindProperty("arrayVar3");
        arrayVar4 = SOTarget.FindProperty("arrayVar4");
        arrayVar5 = SOTarget.FindProperty("arrayVar5");
    }

    public override void OnInspectorGUI() {
        SOTarget.Update();

        EditorGUI.BeginChangeCheck();

        myTarget.toolbarTop = GUILayout.Toolbar(myTarget.toolbarTop, new string[] {"Words", "Numbers", "Boolean", "List"});

        switch (myTarget.toolbarTop) {
            case 0:
                myTarget.toolbarBottom = 4;
                myTarget.currentTab = "Words";
                break;

            case 1:
                myTarget.toolbarBottom = 4;
                myTarget.currentTab = "Numbers";
                break;

            case 2:
                myTarget.toolbarBottom = 4;
                myTarget.currentTab = "Booleans";
                break;

            case 3:
                myTarget.toolbarBottom = 4;
                myTarget.currentTab = "Lists";
                break;
        }

        myTarget.toolbarBottom = GUILayout.Toolbar(myTarget.toolbarBottom, new string[] { "Arrays", "Tab2", "Tab3", "Tab4" });

        switch (myTarget.toolbarBottom) {
            case 0:
                myTarget.toolbarTop = 4;
                myTarget.currentTab = "Arrays";
                break;

            case 1:
                myTarget.toolbarTop = 4;
                myTarget.currentTab = "Tab2";
                break;

            case 2:
                myTarget.toolbarTop = 4;
                myTarget.currentTab = "Tab3";
                break;

            case 3:
                myTarget.toolbarTop = 4;
                myTarget.currentTab = "Tab4";
                break;
        }


        if (EditorGUI.EndChangeCheck()) {
            SOTarget.ApplyModifiedProperties();
            GUI.FocusControl(null);
        }

        EditorGUI.BeginChangeCheck();

        switch (myTarget.currentTab) {
            case "Words":
                EditorGUILayout.PropertyField(stringVar1);
                EditorGUILayout.PropertyField(stringVar2);
                EditorGUILayout.PropertyField(stringVar3);
                EditorGUILayout.PropertyField(stringVar4);
                EditorGUILayout.PropertyField(stringVar5);
                break;

            case "Numbers":
                EditorGUILayout.PropertyField(intVar1);
                EditorGUILayout.PropertyField(intVar2);
                EditorGUILayout.PropertyField(intVar3);
                EditorGUILayout.PropertyField(intVar4);
                EditorGUILayout.PropertyField(intVar5);
                break;

            case "Booleans":
                EditorGUILayout.PropertyField(boolVar1);
                EditorGUILayout.PropertyField(boolVar2);
                EditorGUILayout.PropertyField(boolVar3);
                EditorGUILayout.PropertyField(boolVar4);
                EditorGUILayout.PropertyField(boolVar5);
                break;

            case "Lists":
                EditorGUILayout.PropertyField(listVar1);
                EditorGUILayout.PropertyField(listVar2);
                EditorGUILayout.PropertyField(listVar3);
                EditorGUILayout.PropertyField(listVar4);
                EditorGUILayout.PropertyField(listVar5);
                break;

            case "Arrays":
                EditorGUILayout.PropertyField(arrayVar1);
                EditorGUILayout.PropertyField(arrayVar2);
                EditorGUILayout.PropertyField(arrayVar3);
                EditorGUILayout.PropertyField(arrayVar4);
                EditorGUILayout.PropertyField(arrayVar5);
                break;
        }

        if (EditorGUI.EndChangeCheck()) {
            SOTarget.ApplyModifiedProperties();
        }


    }
}
