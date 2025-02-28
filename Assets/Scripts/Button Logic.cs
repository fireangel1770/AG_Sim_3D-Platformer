using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ButtonLogic : MonoBehaviour
{
    [SerializeField] PlayerStats myStats;

    [SerializeField] Button ButtonRestart;
    [SerializeField] Button ButtonMenu;
    [SerializeField] Button ButtonStart;
    [SerializeField] Button ButtonQuit;

    public void ResetGame()
    {
        SceneManager.LoadScene("MainGame");
        myStats.health = 10;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        myStats.health = 10;
    }
    public void GameStart()
    {
        SceneManager.LoadScene("MainGame");
        myStats.health = 10;
    }
    public void Quit()
    {
        Application.Quit();
    }
}
