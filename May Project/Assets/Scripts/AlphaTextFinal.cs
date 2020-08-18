using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Diagnostics;
using Debug = UnityEngine.Debug;

public class AlphaTextFinal : MonoBehaviour
{

    public float speedFade;
    private float count;
    public Image texto;
    public float transitionTime = 1f;
    public Animator transition;
    public string nomeDaCena;
    //public GameObject mayTexto;


    // Use this for initialization
    void Start()
    {        
        Cursor.visible = false;
       
    }

    // Update is called once per frame
    void Update()
    {

        
        Invoke("PressAny2", 17.5f);      

    }

    /*void MayTexto()
    {
        mayTexto.SetActive(true);
    }*/

    void PressAny2()
    {
        count += speedFade * Time.deltaTime;

        texto.color = new Color(0.9f, 1f, 2f, Mathf.Sin(count) * 2f);
        Cursor.visible = true;

        if (Input.anyKeyDown)
        {
            BGSoundScript.Instance.gameObject.GetComponent<AudioSource>().Stop();
            LoadNextLevel2();
        }
    }

    public void LoadNextLevel2()
    {
        SceneManager.LoadScene(nomeDaCena);
        Debug.Log("entrou no Load");
    }       
}
