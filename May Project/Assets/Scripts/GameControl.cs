using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {

    [SerializeField]
    private Transform[] pictures;

    public static bool youWin;
    public float transitionTime = 1f;
    public Animator transition;

    //Use this for initialization
    void Start ()
    {
        youWin = false;

    }
   
    //Update is called once per frame
    void Update ()
    {
        if (pictures[0].rotation.z == 0 &&
            pictures[1].rotation.z == 0)            
        {
            Debug.Log("teste");
            youWin = true;
            LoadNextLevel();
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
