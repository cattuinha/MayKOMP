using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using CameraFading;

public class GameControlSingle : MonoBehaviour {

    [SerializeField]
    private Transform[] pictures;

    public static bool youWin;
    public float transitionTime = 1f;
    
    public Animator transition;
    public AudioSource audioMontando;
    public AudioSource audioCompleto;
    public AudioSource SFXCompleto;

    private CarregarClick carregarClick;

    //Use this for initialization
    void Start ()
    {
        audioMontando.Play();
        audioCompleto.Stop();
        SFXCompleto.Stop();
        youWin = false;
        Cursor.visible = true;
        Screen.lockCursor = false;        
        carregarClick = GameObject.Find("LevelLoader").GetComponentInChildren<CarregarClick>();        
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
        Invoke ("Socorro", 1f);                
    }

    void Socorro()
    {
        audioCompleto.Play();
        carregarClick.AlterarCondicao();        
    }

    /*void PressAny()
    {
        Debug.Log("entrou no PressAny");
        count += speedFade * Time.deltaTime;

        texto.color = new Color(0.9f, 1f, 2f, Mathf.Sin(count) * 2f);
        
        if (Input.anyKeyDown)
        {
            BGSoundScript.Instance.gameObject.GetComponent<AudioSource>().Stop();
            LoadNextLevel();
        }
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        Debug.Log("entrou no Load");
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);


    }*/
}
