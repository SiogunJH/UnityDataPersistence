using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance { get; private set; }
    public TMP_InputField Name;
    public string PlayerName;
    public void GoToGame()
    {
        if (Name.text != "")
        {
            PlayerName = Name.text;
            SceneManager.LoadScene("Game");
        }
    }
    public void GoToMenu() => SceneManager.LoadScene("Menu");
    public void Quit() => Application.Quit();
    private void Awake()
    {
        // If exists, remove itself
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        //In other case, DontDestroyOnLoad
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
