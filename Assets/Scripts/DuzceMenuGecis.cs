using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DuzceMenuGecis : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnStartButtonClicked()
    {
        SceneManager.LoadScene(4);
    }
    public void OnExitButtonClicked()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void OnAmpfilierButtonCliced()
    {
        SceneManager.LoadScene(2);
    }

    public void OnComputerRoomButtonClicked()
    {
        SceneManager.LoadScene(1);
    }

    public void OnDuzceUniversityClicked()
    {
        SceneManager.LoadScene(3);
    }
}
