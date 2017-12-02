using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour {

	private List<Class> m_Classes;

	void start()
	{
		m_Classes = new List<Class> ();

		m_Classes.Add(new Class() {ClassName = "Warrior", Strength = 4, Intelligence = 2, Agility = 3, Magic = 1 };
	}
}
