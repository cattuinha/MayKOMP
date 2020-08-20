using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using CameraFading;

public class GameControlSingle : MonoBehaviour {

    [SerializeField]
    private Transform[] pictures;

    public static bool youWinSingle;
    public float transitionTime = 1f;
    
    public Animator transition;
    public AudioSource audioMontando;
    public AudioSource audioCompleto;
    public AudioSource SFXCompleto;

    private CarregarClick carregarClick;


    //Use this for initialization
    void Start ()
    {
        youWinSingle = false;
        audioMontando.Play();
        audioCompleto.Stop();
        SFXCompleto.Stop();
        Cursor.visible = true;
        Screen.lockCursor = false;        
        carregarClick = GameObject.Find("LevelLoader").GetComponentInChildren<CarregarClick>();
    }

    //Update is called once per frame
    void Update()

    {

        if (pictures[0].rotation.z == 0 &&
            pictures[1].rotation.z == 0 &&
            pictures[2].rotation.z == 0 &&
            pictures[3].rotation.z == 0 &&
            pictures[4].rotation.z == 0 &&
            pictures[5].rotation.z == 0 &&
            pictures[6].rotation.z == 0 &&
            pictures[7].rotation.z == 0 &&
            pictures[8].rotation.z == 0 &&
            pictures[9].rotation.z == 0 &&
            pictures[10].rotation.z == 0 &&
            pictures[11].rotation.z == 0 &&
            pictures[12].rotation.z == 0 &&
            pictures[13].rotation.z == 0 &&
            pictures[14].rotation.z == 0 &&
            pictures[15].rotation.z == 0 &&
            pictures[16].rotation.z == 0 &&
            pictures[17].rotation.z == 0 &&
            pictures[18].rotation.z == 0 &&
            pictures[19].rotation.z == 0 &&
            pictures[20].rotation.z == 0 &&
            pictures[21].rotation.z == 0 &&
            pictures[22].rotation.z == 0 &&
            pictures[23].rotation.z == 0 &&
            pictures[24].rotation.z == 0 &&
            pictures[25].rotation.z == 0 &&
            pictures[26].rotation.z == 0 &&
            pictures[27].rotation.z == 0 &&
            pictures[28].rotation.z == 0 &&
            pictures[29].rotation.z == 0 &&
            pictures[30].rotation.z == 0 &&
            pictures[31].rotation.z == 0 &&
            pictures[32].rotation.z == 0 &&
            pictures[33].rotation.z == 0 &&
            pictures[34].rotation.z == 0 &&
            pictures[35].rotation.z == 0 &&
            pictures[36].rotation.z == 0 &&
            pictures[37].rotation.z == 0 &&
            pictures[38].rotation.z == 0 &&
            pictures[39].rotation.z == 0 &&
            pictures[40].rotation.z == 0 &&
            pictures[41].rotation.z == 0 &&
            pictures[42].rotation.z == 0 &&
            pictures[43].rotation.z == 0 &&
            pictures[44].rotation.z == 0 &&
            pictures[45].rotation.z == 0 &&
            pictures[46].rotation.z == 0 &&
            pictures[47].rotation.z == 0 &&
            pictures[48].rotation.z == 0 &&
            pictures[49].rotation.z == 0 &&
            pictures[50].rotation.z == 0 &&
            pictures[51].rotation.z == 0 &&
            pictures[52].rotation.z == 0 &&
            pictures[53].rotation.z == 0 &&
            pictures[54].rotation.z == 0 &&
            pictures[55].rotation.z == 0 &&
            pictures[56].rotation.z == 0 &&
            pictures[57].rotation.z == 0 &&
            pictures[58].rotation.z == 0 &&
            pictures[59].rotation.z == 0 &&
            pictures[60].rotation.z == 0 &&
            pictures[61].rotation.z == 0 &&
            pictures[62].rotation.z == 0 &&
            pictures[63].rotation.z == 0 &&
            pictures[64].rotation.z == 0 &&
            pictures[65].rotation.z == 0 &&
            pictures[66].rotation.z == 0 &&
            pictures[67].rotation.z == 0 &&
            pictures[68].rotation.z == 0 &&
            pictures[69].rotation.z == 0 &&
            pictures[70].rotation.z == 0 &&
            pictures[71].rotation.z == 0 &&
            pictures[72].rotation.z == 0 &&
            pictures[73].rotation.z == 0 &&
            pictures[74].rotation.z == 0 &&
            pictures[75].rotation.z == 0 &&
            pictures[76].rotation.z == 0 &&
            pictures[77].rotation.z == 0 &&
            pictures[78].rotation.z == 0 &&
            pictures[79].rotation.z == 0 &&
            pictures[80].rotation.z == 0 &&
            pictures[81].rotation.z == 0 &&
            pictures[82].rotation.z == 0 &&
            pictures[83].rotation.z == 0 &&
            pictures[84].rotation.z == 0 &&
            pictures[85].rotation.z == 0 &&
            pictures[86].rotation.z == 0 &&
            pictures[87].rotation.z == 0 &&
            pictures[88].rotation.z == 0 &&
            pictures[89].rotation.z == 0 &&
            pictures[90].rotation.z == 0 &&
            pictures[91].rotation.z == 0 &&
            pictures[92].rotation.z == 0 &&
            pictures[93].rotation.z == 0 &&
            pictures[94].rotation.z == 0 &&
            pictures[95].rotation.z == 0 &&
            pictures[96].rotation.z == 0 &&
            pictures[97].rotation.z == 0 &&
            pictures[98].rotation.z == 0 &&
            pictures[99].rotation.z == 0 &&
            pictures[100].rotation.z == 0 &&
            pictures[101].rotation.z == 0 &&
            pictures[102].rotation.z == 0 &&
            pictures[103].rotation.z == 0 &&
            pictures[104].rotation.z == 0 &&
            pictures[105].rotation.z == 0 &&
            pictures[106].rotation.z == 0 &&
            pictures[107].rotation.z == 0 &&
            pictures[108].rotation.z == 0 &&
            pictures[109].rotation.z == 0 &&
            pictures[110].rotation.z == 0 &&
            pictures[111].rotation.z == 0 &&
            pictures[112].rotation.z == 0 &&
            pictures[113].rotation.z == 0 &&
            pictures[114].rotation.z == 0 &&
            pictures[115].rotation.z == 0 &&
            pictures[116].rotation.z == 0 &&
            pictures[117].rotation.z == 0 &&
            pictures[118].rotation.z == 0 &&
            pictures[119].rotation.z == 0 &&
            pictures[120].rotation.z == 0 &&
            pictures[121].rotation.z == 0 &&
            pictures[122].rotation.z == 0 &&
            pictures[123].rotation.z == 0 &&
            pictures[124].rotation.z == 0 &&
            pictures[125].rotation.z == 0 &&
            pictures[126].rotation.z == 0 &&
            pictures[127].rotation.z == 0 &&
            pictures[128].rotation.z == 0 &&
            pictures[129].rotation.z == 0 &&
            pictures[130].rotation.z == 0 &&
            pictures[131].rotation.z == 0 &&
            pictures[132].rotation.z == 0 &&
            pictures[133].rotation.z == 0 &&
            pictures[134].rotation.z == 0 &&
            pictures[135].rotation.z == 0 &&
            pictures[136].rotation.z == 0 &&
            pictures[137].rotation.z == 0 &&
            pictures[138].rotation.z == 0 &&
            pictures[139].rotation.z == 0 &&
            pictures[140].rotation.z == 0 &&
            pictures[141].rotation.z == 0 &&
            pictures[142].rotation.z == 0 &&
            pictures[143].rotation.z == 0 &&
            youWinSingle == false) 
        {
            FuncaoBonitinha();                       
        }
    }


    void FuncaoBonitinha()
    {
        youWinSingle = true;
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
