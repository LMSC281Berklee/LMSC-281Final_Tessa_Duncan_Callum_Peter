using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelector : MonoBehaviour {

	private List<GameObject> models;

	private void Start()
	{
		models = new List<GameObject> ();
		foreach(Transform t in transform)
		{
			models.Add (t.gameObject);
		}
	}
}