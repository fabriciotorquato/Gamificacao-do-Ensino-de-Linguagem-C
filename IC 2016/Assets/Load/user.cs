using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class user : MonoBehaviour {
	public bool maiusculo=false,tamanho=false;
	public Text username;
	public static string nomeus;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (tamanho == false) {
			if (Input.GetKeyDown (KeyCode.Q)) {
				if (maiusculo == false)
					username.text = username.text + "q";
				else
					username.text = username.text + "Q";

			} else if (Input.GetKeyDown (KeyCode.W)) {
				if (maiusculo == false)
					username.text = username.text + "w";
				else
					username.text = username.text + "W";

			} else if (Input.GetKeyDown (KeyCode.E)) {
				if (maiusculo == false)
					username.text = username.text + "e";
				else
					username.text = username.text + "E";

			} else if (Input.GetKeyDown (KeyCode.R)) {
				if (maiusculo == false)
					username.text = username.text + "r";
				else
					username.text = username.text + "R";

			} else if (Input.GetKeyDown (KeyCode.T)) {
				if (maiusculo == false)
					username.text = username.text + "t";
				else
					username.text = username.text + "T";

			} else if (Input.GetKeyDown (KeyCode.Y)) {
				if (maiusculo == false)
					username.text = username.text + "y";
				else
					username.text = username.text + "Y";

			} else if (Input.GetKeyDown (KeyCode.U)) {
				if (maiusculo == false)
					username.text = username.text + "u";
				else
					username.text = username.text + "U";

			} else if (Input.GetKeyDown (KeyCode.I)) {
				if (maiusculo == false)
					username.text = username.text + "i";
				else
					username.text = username.text + "I";

			} else if (Input.GetKeyDown (KeyCode.O)) {
				if (maiusculo == false)
					username.text = username.text + "o";
				else
					username.text = username.text + "O";

			} else if (Input.GetKeyDown (KeyCode.P)) {
				if (maiusculo == false)
					username.text = username.text + "p";
				else
					username.text = username.text + "P";

			} else if (Input.GetKeyDown (KeyCode.A)) {
				if (maiusculo == false)
					username.text = username.text + "a";
				else
					username.text = username.text + "A";

			} else if (Input.GetKeyDown (KeyCode.S)) {
				if (maiusculo == false)
					username.text = username.text + "s";
				else
					username.text = username.text + "S";

			} else if (Input.GetKeyDown (KeyCode.D)) {
				if (maiusculo == false)
					username.text = username.text + "d";
				else
					username.text = username.text + "D";

			} else if (Input.GetKeyDown (KeyCode.F)) {
				if (maiusculo == false)
					username.text = username.text + "f";
				else
					username.text = username.text + "F";

			} else if (Input.GetKeyDown (KeyCode.G)) {
				if (maiusculo == false)
					username.text = username.text + "g";
				else
					username.text = username.text + "G";

			} else if (Input.GetKeyDown (KeyCode.H)) {
				if (maiusculo == false)
					username.text = username.text + "h";
				else
					username.text = username.text + "H";

			} else if (Input.GetKeyDown (KeyCode.J)) {
				if (maiusculo == false)
					username.text = username.text + "j";
				else
					username.text = username.text + "J";

			} else if (Input.GetKeyDown (KeyCode.K)) {
				if (maiusculo == false)
					username.text = username.text + "k";
				else
					username.text = username.text + "K";

			} else if (Input.GetKeyDown (KeyCode.L)) {
				if (maiusculo == false)
					username.text = username.text + "l";
				else
					username.text = username.text + "L";

			} else if (Input.GetKeyDown (KeyCode.Z)) {
				if (maiusculo == false)
					username.text = username.text + "z";
				else
					username.text = username.text + "Z";

			} else if (Input.GetKeyDown (KeyCode.X)) {
				if (maiusculo == false)
					username.text = username.text + "x";
				else
					username.text = username.text + "X";

			} else if (Input.GetKeyDown (KeyCode.C)) {
				if (maiusculo == false)
					username.text = username.text + "c";
				else
					username.text = username.text + "C";

			} else if (Input.GetKeyDown (KeyCode.V)) {
				if (maiusculo == false)
					username.text = username.text + "v";
				else
					username.text = username.text + "V";

			} else if (Input.GetKeyDown (KeyCode.B)) {
				if (maiusculo == false)
					username.text = username.text + "b";
				else
					username.text = username.text + "B";

			} else if (Input.GetKeyDown (KeyCode.N)) {
				if (maiusculo == false)
					username.text = username.text + "n";
				else
					username.text = username.text + "N";

			} else if (Input.GetKeyDown (KeyCode.M)) {
				if (maiusculo == false)
					username.text = username.text + "m";
				else
					username.text = username.text + "M";

			} else if (Input.GetKeyDown (KeyCode.Space)) {

				username.text = username.text + "_";

			} else if (Input.GetKeyDown (KeyCode.CapsLock)) {
				if (maiusculo == false)
					maiusculo = true;
				else
					maiusculo = false;

			} else if (Input.GetKeyDown (KeyCode.Alpha0)) {
				username.text = username.text + "0";

			} else if (Input.GetKeyDown (KeyCode.Alpha1)) {
				username.text = username.text + "1";

			} else if (Input.GetKeyDown (KeyCode.Alpha2)) {
				username.text = username.text + "2";

			} else if (Input.GetKeyDown (KeyCode.Alpha3)) {
				username.text = username.text + "3";

			} else if (Input.GetKeyDown (KeyCode.Alpha4)) {
				username.text = username.text + "4";

			} else if (Input.GetKeyDown (KeyCode.Alpha5)) {
				username.text = username.text + "5";

			} else if (Input.GetKeyDown (KeyCode.Alpha6)) {
				username.text = username.text + "6";

			} else if (Input.GetKeyDown (KeyCode.Alpha7)) {
				username.text = username.text + "7";

			} else if (Input.GetKeyDown (KeyCode.Alpha8)) {
				username.text = username.text + "8";

			} else if (Input.GetKeyDown (KeyCode.Alpha9)) {
				username.text = username.text + "9";

			}
		}
		if (Input.GetKeyDown(KeyCode.Backspace))
		{
			if (nomeus.Length > 0) {
				nomeus = nomeus.Substring (0, nomeus.Length - 1);
				username.text = nomeus;
			}
		}
		nomeus=username.text;
		if (nomeus.Length > 15)
			tamanho = true;
		else
			tamanho = false;
		if (Input.GetKeyDown(KeyCode.Return))
		{
			PlayerPrefs.SetString ("user",nomeus);
			SceneManager.LoadScene ("menu_load");
		}
		
	}
}
