using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    // Add a potential scene switch animation (later on)

    public Collider2D other;
    //public int sceneIndex; <-- its easlier to use names
    public string sceneName;
    public bool needTrigger = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!needTrigger)
        {
            if (other.CompareTag("Player"))
            {
                SceneManager.LoadScene(sceneName);
            }
        }
        else
        {
            if (other.CompareTag("Player"))
            {
                if (Input.GetKeyDown(KeyCode.Z))
                {
                    SceneManager.LoadScene(sceneName);
                }
            }

        }
    }
}
