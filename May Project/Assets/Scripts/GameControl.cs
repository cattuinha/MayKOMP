using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using CameraFading;

public class GameControl : MonoBehaviour {

    [SerializeField]
    private Transform[] pictures;

    public static bool youWin;
    public float transitionTime = 1f;
    public Animator transition;
    public AudioSource audioMontando;
    public AudioSource audioCompleto;
    public AudioSource SFXCompleto;

    //Use this for initialization
    void Start ()
    {
        audioMontando.Play();
        audioCompleto.Stop();
        SFXCompleto.Stop();
        youWin = false;
        Cursor.visible = true;
        Screen.lockCursor = false;

    }

    //Update is called once per frame
    void Update()

    {

        if (pictures[0].rotation.z == 0 &&
            pictures[1].rotation.z == 0 &&
            youWin == false) 
        {
            FuncaoBonitinha();
        }
    }


    void FuncaoBonitinha()
    {
        youWin = true;
        Cursor.visible = false;
        audioMontando.Stop();
        SFXCompleto.Play();
        Invoke ("Socorro", 1.5f);                
    }

    void Socorro()
    {
        audioCompleto.Play();        
        Invoke("LoadNextLevel", 5f);
    }

    void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        Debug.Log("entrou no Load");
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);


    }
}
