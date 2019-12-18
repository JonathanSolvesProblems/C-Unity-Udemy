using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")] // for scriptableobjects
public class State : ScriptableObject
{
    [TextArea(10,14)][SerializeField] string storyText; // TextArea(starting minumum, maximum can go with enter key)

    public string GetStateStory()
    {
        return storyText;
    }
}

/* 
 * Can store data inside of scriptable objects then call them in our cs file to display the information.

Normally have to attach every script to a game object, however, this rule does not apply for scriptable objects. If derived from MonoBehaviour class then has to add to game object

    Id create a script object and derive it from ScriptableObject, CreateAssetMenu and set the name = to class name, will touch what that means later.

    Remember SerializeField makes it available in the inspector. storyText, allows field in our scriptable object.

    In unity, can do create, then name of class to make an object of that type.
*/