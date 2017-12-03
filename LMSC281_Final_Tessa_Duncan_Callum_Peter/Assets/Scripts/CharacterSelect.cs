<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Character")]
public class CharacterSelect : ScriptableObject {

	public string characterName = "Default";
	public int Strength = 1;
	public int Intelligence = 1;
	public int Agility = 1;
	public int Magic = 1;
}

=======
﻿using System.Collections.Generic;
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
>>>>>>> 3c6757853d2cb9c54fe9475f7e3479c8bbb44c80
