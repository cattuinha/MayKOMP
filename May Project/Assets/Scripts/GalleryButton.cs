using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GalleryButton : MonoBehaviour
{
    private int galeria;
    public GameObject[] botaoMenu;
     

    void Start()
    {
        galeria = PlayerPrefs.GetInt("Gallery");
        if (galeria == 0)
        {
            for (int i = 0; i < botaoMenu.Length; i++)
            {
                botaoMenu[i].SetActive(false);
            }
        }
        else
        {
            for (int i = 0; i < botaoMenu.Length; i++)
            {
                botaoMenu[i].SetActive(true);
            }
        }
    }
}
