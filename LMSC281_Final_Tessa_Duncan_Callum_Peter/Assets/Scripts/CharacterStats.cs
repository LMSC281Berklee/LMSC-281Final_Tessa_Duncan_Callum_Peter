using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour {

	private List<Class> m_Classes;

	void start()
	{
		m_Classes = new List<Class> ();

		m_Classes.Add(new Class() {ClassName = "Warrior", Strength = 4, Intelligence = 2, Agility = 3, Magic = 1 });
		m_Classes.Add(new Class() {ClassName = "Mage", Strength = 2, Intelligence = 3, Agility = 1, Magic = 4 });
		m_Classes.Add(new Class() {ClassName = "Scholar", Strength = 1, Intelligence = 4, Agility = 2, Magic = 3 });
		m_Classes.Add(new Class() {ClassName = "Rogue", Strength = 3, Intelligence = 2, Agility = 4, Magic = 1 });
	}
}