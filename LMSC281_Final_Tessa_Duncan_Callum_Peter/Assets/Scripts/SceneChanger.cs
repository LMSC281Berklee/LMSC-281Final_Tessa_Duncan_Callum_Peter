using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChanger : MonoBehaviour
{
	public void LoadScene (int SceneNum)
	{
		Application.LoadLevel(SceneNum);
	}
}
