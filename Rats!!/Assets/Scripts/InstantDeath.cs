using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using UnityEngine.SceneManagement;

public class InstantDeath : MonoBehaviour
{
    public Collider2D objectCollider;
    public Collider2D anotherCollider;
    public string sceneName;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(objectCollider.IsTouching(anotherCollider))
        {
            SceneManager.LoadScene(sceneName);
        }
        
    }
}