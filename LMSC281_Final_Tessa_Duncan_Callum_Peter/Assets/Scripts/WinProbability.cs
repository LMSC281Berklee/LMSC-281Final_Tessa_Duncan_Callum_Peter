using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinProbability : MonoBehaviour
{
	float chance = 0.5f;
	public GameObject Here;
	public Text outputText;

	public void DetermineOutcome()
	{
		float random = Random.Range(0.0f, 1.0f);

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
		outputText.text = "The sea of Skeletones part and you make you strut your way through.";
	}

	public void Death()
	{
		Debug.Log ("You have died");
		SceneManager.LoadScene("Death Scene");
	}
}