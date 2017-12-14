using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterCreator : MonoBehaviour
{
	// list of options for dropdown menu
	List<string> characters = new List<string>() {"Warrior", "Mage", "Rogue", "Scholar"};
	
    // variable for input field
    public InputField NameField;
	
	// variable for dropdown menu
	public Dropdown CharacterMenu;

    // variable for the player name
    public string CharName;

    public void OnSubmit(int index)
    {
        // set CharName to text NameField
        CharName = NameField.text;

        // display character name in console
        Debug.Log("Hello " + CharName + " the " + characters[index]);
    }
	
	void Start ()
	{
		PopulateList();
	}
	
	void PopulateList()
	{
		CharacterMenu.AddOptions(characters);
	}
}
