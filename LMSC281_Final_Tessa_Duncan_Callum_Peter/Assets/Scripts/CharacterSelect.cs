using System.Collections;
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

