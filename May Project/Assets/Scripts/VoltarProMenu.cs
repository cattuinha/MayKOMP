using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VoltarProMenu : MonoBehaviour
{
    private int currentSceneIndex;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (BGSoundScript.Instance)
            {
                BGSoundScript.Instance.gameObject.GetComponent<AudioSource>().Stop();
            }
            Cursor.visible = true;
            Screen.lockCursor = false;
            currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            PlayerPrefs.SetInt("SavedScene", currentSceneIndex);
            SceneManager.LoadScene(0);
        }
    }
}
