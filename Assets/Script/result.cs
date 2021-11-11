using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class result : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
  
    void Updae()
    {
        SceneManager.LoadScene("result");
        SceneManager.LoadScene("GameMain");
    }
}
