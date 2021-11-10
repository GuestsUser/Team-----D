using UnityEngine;
using UnityEngine.UI; // 追加
using UnityEngine.SceneManagement;

class clear : MonoBehaviour
{
    private AudioSource audioSource; // オーディオソース
    public AudioClip clearSound;
    public GameObject clearUI;
    public Text gameClearMessage; // 追加
    Transform myTransform;
    bool clearsound = false;
    private float step_time = 0;

    void Start()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();
        myTransform = transform;

    }

    void Update()
    {
        step_time += Time.deltaTime;

        if (!clearsound)
            if (myTransform.childCount == 0)

            {

                gameClearMessage.text = "Game Clear"; // 追加


                audioSource.Play();
                clearsound = true;

                Time.timeScale = 0f;
                clearUI.SetActive(false);
                
                if (step_time >= 3.0f)
                {
                    SceneManager.LoadScene("result");
                }
            }
    }
}
