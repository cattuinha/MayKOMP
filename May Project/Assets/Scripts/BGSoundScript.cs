using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGSoundScript : MonoBehaviour {

	// Use this for initialization
	

    //Play Global
    private static BGSoundScript instance = null;
    public static BGSoundScript Instance
    {
        get { return instance; }
    }

    void Start()
    {
        /*if (instance != null && instance != this)
        {
//            Destroy(this.gameObject);
            return;
        }
        else*/
        //{
            instance = this;
        //}

        DontDestroyOnLoad(this.gameObject);
    }
    //Play Global End

}
