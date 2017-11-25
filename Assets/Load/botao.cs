using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class botao : MonoBehaviour {
	public Text score;
	public Text user;
	public Text game;
	public string nome;
	int ponto;
	public GameObject login,cadastro;

	void Start () {

		if (PlayerPrefs.HasKey ("user")) {
			ponto = PlayerPrefs.GetInt ("score");
			game.text = "Entrar";
			score.text = "Score: " + ponto;
			nome = PlayerPrefs.GetString ("user");
			user.text = "User: " + nome;
		} 
	}
	public void continuar(){
		if (!PlayerPrefs.HasKey ("user")) {
			PlayerPrefs.SetInt ("score", 0);	
			game.text = "Entrar";
			cadastro.SetActive (true);
			login.SetActive (false);
        }
		else {
			SceneManager.LoadScene ("menu_inicial");
		}
	}
	public void deletar()
	{
		PlayerPrefs.DeleteAll ();
		game.text = "Crie uma conta";
		user.text = "";
		score.text = "";
		menu_load_sv.score = 0;
	}
}
