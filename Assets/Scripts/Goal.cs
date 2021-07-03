﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D col) {
		if (col.CompareTag("Player")) {
			print ("Game Won! :D");
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
	}
}
