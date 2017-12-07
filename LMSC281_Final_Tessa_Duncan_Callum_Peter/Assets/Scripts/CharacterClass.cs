using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	[CreateAssetMenu (menuName = "Character Class")]
	public class CharacterClass : ScriptableObject {

		public string characterName = "Default";
		public int Strength = 1;
		public int Intelligence = 1;
		public int Agility = 1;
		public int Magic = 1;
	}
