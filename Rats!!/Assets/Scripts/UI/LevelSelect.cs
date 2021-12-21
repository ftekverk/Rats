using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void Level1()
    {
        SceneManager.LoadScene("TutorialScene");
    }
    public void Level2()
    {
        SceneManager.LoadScene("VerticalPipeLevel");
    }
    public void Level3()
    {
        SceneManager.LoadScene("LightDark");
    }
    public void Level4()
    {
        SceneManager.LoadScene("FlowingWater");
    }
    public void Level5()
    {
        SceneManager.LoadScene("Subway");
    }
}
