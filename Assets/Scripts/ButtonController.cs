using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class ButtonController : MonoBehaviour
{
    private string newGameLevel = "LevelTwo";

    public void OnButtonPress()
    {
        Debug.Log("SOMETHING!");
        SceneManager.LoadScene(newGameLevel);
    }
}
