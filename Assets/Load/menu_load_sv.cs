using UnityEngine;
using System.Collections;

public class menu_load_sv : MonoBehaviour {
	public static int score;
    public static string usuario;
	public int tst;
	public static int[] mundos=new int[2];
	private GameObject[] saves;


	void Awake() //É executada antes do primeiro frame do jogo (primeira função a ser executada)
	{
		saves = GameObject.FindGameObjectsWithTag ("saves"); //add todos os objects com tag saves
		if (saves.Length > 2) {
			Destroy (saves [0]);
		}
		DontDestroyOnLoad (transform.gameObject);
	}
	public void SaveGame()
	{
		PlayerPrefs.SetInt ("score",score);
        PlayerPrefs.SetString("nomeus",usuario);
    }
	void Start () {
		if (PlayerPrefs.HasKey ("score")) {
			score = PlayerPrefs.GetInt ("score");
           
        } 
		else {
			PlayerPrefs.SetInt ("score",score);
           
        }
        if (PlayerPrefs.HasKey("user"))
        {
            usuario = PlayerPrefs.GetString("nomeus");
        }
    }

}
	