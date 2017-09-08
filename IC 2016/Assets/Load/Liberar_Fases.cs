using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Liberar_Fases : MonoBehaviour {

    public GameObject[] nivel = new GameObject[14];
    public GameObject[] trans = new GameObject[18];
    public Color c;
    public int pontuacao;
    private int cena4, cena5, cena6, cena7;

    // Use this for initialization
    void Start () {
	    pontuacao = menu_load_sv.score;
        c.a = 256;
        if (PlayerPrefs.HasKey("fase" + 4))
        {
            cena4 = PlayerPrefs.GetInt("fase" + 4);
        }
        if (PlayerPrefs.HasKey("fase" + 5))
        {
            cena5 = PlayerPrefs.GetInt("fase" + 5);
        }
        if (PlayerPrefs.HasKey("fase" + 6))
        {
            cena6 = PlayerPrefs.GetInt("fase" + 6);
        }
        if (PlayerPrefs.HasKey("fase" + 7))
        {
            cena7 = PlayerPrefs.GetInt("fase" + 7);
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (cena7 == 1)
        {
            trans[0].GetComponent<Image>().color = c;
            trans[1].GetComponent<Image>().color = c;
            trans[2].GetComponent<Image>().color = c;
            nivel[0].GetComponent<Button>().interactable = true;
        }
        if (cena4 == 1)
        {
            trans[3].GetComponent<Image>().color = c;
            trans[4].GetComponent<Image>().color = c;
            trans[5].GetComponent<Image>().color = c;
            trans[6].GetComponent<Image>().color = c;
        }
        if (cena6 == 1)
        {
            trans[7].GetComponent<Image>().color = c;
            trans[8].GetComponent<Image>().color = c;
            trans[9].GetComponent<Image>().color = c;
            trans[10].GetComponent<Image>().color = c;
        }
        if (cena4 == 1 && cena6==1)
        {
            nivel[1].GetComponent<Button>().interactable = true;
        }
        if (cena5 == 1)
        {
            trans[11].GetComponent<Image>().color = c;
        }
    }
}
