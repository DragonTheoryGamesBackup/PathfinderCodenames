using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using System;

public class MenuController : MonoBehaviour {

    public int levelIndex = 1;

    public void SetLevel(int lvl) {
        levelIndex = lvl;
    }

    public void PlayGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + levelIndex);
    }

    public void StartOver() {
        SceneManager.LoadScene(0);
    }

    public void PlayAgain() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    
}