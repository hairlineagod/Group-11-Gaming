using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Author: [Kalkat, Karen & Xiong, Timmie]
 * Last Updated: [12/07/2023]
 * [contains the code for the Game Over screen]
 */

public class GameOverScreen : MonoBehaviour
{
    /// <summary>
    /// allows the player to quit the game at the end screen
    /// </summary>
    public void QuitGame()
    {
        Application.Quit();
    }

    /// <summary>
    /// switches to the game mode select scene
    /// <param name="sceneIndex"></param>
    public void SwitchScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
