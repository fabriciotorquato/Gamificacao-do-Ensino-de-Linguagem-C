using UnityEngine;
using System.Collections;

public class chama_controle : MonoBehaviour {
    public GameObject controle;
	// Use this for initialization
	void Start () {
        controle.GetComponent<fase_ponto>().pontuacao();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
