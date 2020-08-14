using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoPraSalvar : MonoBehaviour
{
    private int currentSceneIndex;
    // Start is called before the first frame update
    void Awake()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("SavedScene", currentSceneIndex);
        Debug.Log("Scene index:" + currentSceneIndex);
    }

    
}
