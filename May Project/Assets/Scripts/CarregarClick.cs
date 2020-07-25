using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CarregarClick : MonoBehaviour
{
    
    public float speedFade;
    private float count;
    public Image texto;
    public float transitionTime = 1f;
    public Animator transition;

    public bool condicao = false;
    
    public void AlterarCondicao()
    {
        condicao = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (condicao)
        Invoke("PressAny", 4f);

    }


    void PressAny()
    {
        Debug.Log("Entrou no load do clickSolo");
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


    }
}
