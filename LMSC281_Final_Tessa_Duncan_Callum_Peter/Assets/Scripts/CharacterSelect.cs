using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour
{
	List<string> characters = new List<string>() {"Warrior", "Mage", "Rogue", "Scholar"};
	
	public Dropdown CharacterMenu;
	public Text selectedCharacter;
	//public Sprite[] charImage;
	
	public void Dropdown_IndexChanged (int index)
	{
		selectedCharacter.text = characters[index];
	}
	
	// Use this for initialization
	void Start ()
	{
		PopulateList();
	}
	
	void PopulateList()
	{
		CharacterMenu.AddOptions(characters);
	}
}
