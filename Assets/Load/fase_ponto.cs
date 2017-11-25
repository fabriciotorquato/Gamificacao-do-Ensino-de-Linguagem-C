using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class fase_ponto : MonoBehaviour {
	public int cod;
	public int ponto;
	public int finaliza;
	void Start () {
		if (PlayerPrefs.HasKey ("fase"+cod)) {
			finaliza = PlayerPrefs.GetInt ("fase"+cod);
		} 
		else {
			PlayerPrefs.SetInt ("fase"+cod,0);
			finaliza = 0;
		}

	}
	public void pontuacao()
	{
		if (finaliza == 0) {
			menu_load_sv.score = menu_load_sv.score+ponto;
			finaliza = 1;
			PlayerPrefs.SetInt ("fase"+cod,1);
			PlayerPrefs.SetInt ("score",menu_load_sv.score);
		}
	}
}
