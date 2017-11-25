using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Sair : MonoBehaviour {

    public Text score, user, info;
    public string nome;
    int ponto;
    public bool acertou;

    void Start () {
        if (PlayerPrefs.HasKey("user"))
        {
            ponto = PlayerPrefs.GetInt("score");
            score.text = "Score: " + ponto;
            nome = PlayerPrefs.GetString("user");
            user.text = "User: " + nome;
            if (acertou == true)
                info.text = "Você concluiu a fase, o que deseja fazer ?";
            if (acertou == false)
                info.text = "Você não acertou essa fase, o que deseja fazer ?";
        }

    }
	
	// Update is called once per frame
	void Update () {
	    
	}
}
