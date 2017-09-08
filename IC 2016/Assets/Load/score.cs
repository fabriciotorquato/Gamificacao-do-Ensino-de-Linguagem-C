using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class score : MonoBehaviour {
    public Text pontos, usuario;
	public int scores;
   
        void Update () {
        usuario.text = "User: " + PlayerPrefs.GetString("user");
        pontos.text = "Score: " + PlayerPrefs.GetInt("score");
        scores =menu_load_sv.score;

	}
}
