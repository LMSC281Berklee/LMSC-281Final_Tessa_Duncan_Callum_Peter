﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
	void changeScene ()
	{
		SceneManager.LoadScene ("Scene 1");
	}
}