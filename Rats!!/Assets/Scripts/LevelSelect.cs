using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void Level1()
    {
        SceneManager.LoadScene("LightDark");
    }
    public void Level2()
    {
        SceneManager.LoadScene("FlowingWater");
    }
}
