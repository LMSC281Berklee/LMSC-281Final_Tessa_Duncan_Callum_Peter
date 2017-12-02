using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterCreator : MonoBehaviour
{
    // variable for input field
    public InputField NameField;

    // variable for the player name
    public string CharName;

    public void OnSubmit()
    {
        // set CharName to text NameField
        CharName = NameField.text;

        // display character name in console
        Debug.Log("Your Player name is: " + CharName);
    }
}
