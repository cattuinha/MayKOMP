using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorController : MonoBehaviour
{
    public GameObject instructions;
    public float transitionTime = 1f;
    public Animator transition;

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Door")
        {
            instructions.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                LoadNextLevel();
            }
            
            

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Door")
        {
            instructions.SetActive(false);
        }
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);


    }
}
