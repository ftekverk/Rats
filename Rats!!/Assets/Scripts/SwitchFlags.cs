using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using UnityEngine.SceneManagement;

public class SwitchFlags : MonoBehaviour
{
    public GameObject greenflag;
    public GameObject redflag;

    // Start is called before the first frame update
    void Start()
    {
        redflag.SetActive(true);
        greenflag.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            redflag.SetActive(false);
            greenflag.SetActive(true);
        }
    }
}
