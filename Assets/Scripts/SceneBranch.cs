using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneBranch : MonoBehaviour {

    public string[] scenes = new string[2];

    public void LoadScene(int index)
    {
        SceneManager.LoadScene(scenes[index]);
    }


    public void Quit()
    {
        Debug.Log("Quit the game");
        Application.Quit();
    }
}
