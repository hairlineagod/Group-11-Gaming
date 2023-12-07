using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Author: [Kalkat, Karen & Xiong, Timmie]
 * Last Updated: [12/07/2023]
 * [contains the code for the Game Mode Select screen]
 */

public class GameModeOptionSelect : MonoBehaviour
{
    public void SwitchScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

}
