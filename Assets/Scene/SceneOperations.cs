using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneOperations : MonoBehaviour
{
    public void LoadSceneSingle()
    {
        SceneManager.LoadScene("Scene/SecondScene", LoadSceneMode.Single);
    }
    
    public void LoadSceneAdditive()
    {
        SceneManager.LoadScene("Scene/SecondScene", LoadSceneMode.Additive);
    }

    public void LoadSceneAsync()
    {
        SceneManager.LoadSceneAsync("Scene/SecondScene", LoadSceneMode.Single).completed += delegate(AsyncOperation asyncOperation)
        {
            Debug.Log("Loading complete");
        };
    }

    public void UnloadScene()
    {
        SceneManager.UnloadSceneAsync("Scene/SecondScene");
    }
    
}
