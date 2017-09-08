using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Liberar_Fases_Treinamento : MonoBehaviour {

    public GameObject[] nivel = new GameObject[2];
    public GameObject[] trans = new GameObject[3];
    public Color c;
    public int pontuacao;
    private int cena1, cena2, cena3;

    // Use this for initialization
    void Start()
    {
        pontuacao = menu_load_sv.score;
        c.a = 256;
        if (PlayerPrefs.HasKey("fase" + 2))
        {
            cena1 = PlayerPrefs.GetInt("fase" + 2);
        }
        if (PlayerPrefs.HasKey("fase" + 1))
        {
            cena3 = PlayerPrefs.GetInt("fase" + 1);
        }
        if (PlayerPrefs.HasKey("fase" + 3))
        {
            cena2 = PlayerPrefs.GetInt("fase" + 3);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        if (cena1==1)
        {
            trans[0].GetComponent<Image>().color = c;
            trans[1].GetComponent<Image>().color = c;
            trans[2].GetComponent<Image>().color = c;
            nivel[0].GetComponent<Button>().interactable = true;
        }
        if (cena2==1)
        {
            trans[3].GetComponent<Image>().color = c;
            trans[4].GetComponent<Image>().color = c;
            nivel[1].GetComponent<Button>().interactable = true;
        }
        if (cena3 == 1)
        {
            trans[5].GetComponent<Image>().color = c;
        }
    }
}

