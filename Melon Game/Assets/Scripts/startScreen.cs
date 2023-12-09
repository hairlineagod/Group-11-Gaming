using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Author: [Kalkat, Karen & Xiong Timmie]
 * Last Updated: [12/07/2023]
 * [contains the code for the Start Screen]
 */

public class startScreen : MonoBehaviour
{
    /// <summary>
    /// quits the game if the player chooses to at the start
    /// </summary>
    public void QuitGame()
    {
        Application.Quit();
    }


    /// <summary>
    /// helps switch the start scene to the game mode select scene
    /// </summary>
    /// <param name="sceneIndex"></param>
    public void SwitchScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

}
