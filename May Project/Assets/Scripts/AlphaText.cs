using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AlphaText : MonoBehaviour
{

    public float speedFade;
    private float count;
    public Image texto;
    public float transitionTime = 1f;
    public Animator transition;
    public AudioSource SFXVirandoPagina;

    // Use this for initialization
    void Start()
    {
        SFXVirandoPagina.Play();
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {

        Invoke("PressAny", 7f);      

    }


    void PressAny()
    {
        count += speedFade * Time.deltaTime;

        texto.color = new Color(0.9f, 1f, 2f, Mathf.Sin(count) * 2f);

        if (Input.anyKeyDown)
        {
            if (BGSoundScript.Instance)
            {
                BGSoundScript.Instance.gameObject.GetComponent<AudioSource>().Stop();
            }               
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


    }
}
