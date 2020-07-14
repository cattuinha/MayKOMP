using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour {

    [SerializeField]
    private Transform[] pictures;

    [SerializeField]
    private GameObject winText;

    public static bool youWin;

    //Use this for initialization
    void Start ()
    {
        winText.SetActive(false);
        youWin = false;

    }
   
    //Update is called once per frame
    void Update ()
    {
        if (pictures[0].rotation.z == 0 &&
            pictures[1].rotation.z == 0 &&
            pictures[2].rotation.z == 0 &&
            pictures[3].rotation.z == 0 &&
            pictures[4].rotation.z == 0 &&
            pictures[6].rotation.z == 0)
        {
            youWin = true;
            winText.SetActive(true);
        }
    }
}
