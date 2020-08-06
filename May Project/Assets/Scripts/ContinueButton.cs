using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueButton : MonoBehaviour
{
    private int sceneToContinue;
    public GameObject[] continuar;
     

    void Start()
    {
        sceneToContinue = PlayerPrefs.GetInt("SavedScene");
        if (sceneToContinue == 0)
        {
            for (int i = 0; i < continuar.Length; i++)
            {
                continuar[i].SetActive(false);
            }
        }
        else
        {
            for (int i = 0; i < continuar.Length; i++)
            {
                continuar[i].SetActive(true);
            }
        }
    }

    public void ContinueGame()
    {
        sceneToContinue = PlayerPrefs.GetInt("SavedScene");

        if (sceneToContinue != 0)
            SceneManager.LoadScene(sceneToContinue);
        else
            return;
    }
}
