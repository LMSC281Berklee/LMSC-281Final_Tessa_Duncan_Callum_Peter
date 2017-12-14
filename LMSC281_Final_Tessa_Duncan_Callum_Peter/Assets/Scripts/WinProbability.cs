using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinProbability : MonoBehaviour
{
	//public int chance = 100;

	public void DetermineOutcome(int chance)
	{
		int random = Random.Range(1, 100);

		if (random < chance)
		{
			Success();
		}
		else if (random >= chance)
		{
			Death();
		}
	}

	public void Success()
	{
		Debug.Log ("You have passed");
	}

	public void Death()
	{
		Debug.Log ("You died lol");
		SceneManager.LoadScene("Death Scene");
	}
}