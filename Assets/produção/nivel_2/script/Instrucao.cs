using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Instrucao : MonoBehaviour {
	public Button prancheta;
	public Button inff;
	public Button okk;



	public void ok(){
		prancheta.gameObject.SetActive (false);
		inff.gameObject.SetActive (true);
		okk.gameObject.SetActive (false);
	}
	public void inf()
	{
		prancheta.gameObject.SetActive (true);
		Instantiate(prancheta);
		okk.gameObject.SetActive (true);
		inff.gameObject.SetActive (false);
	}
}
