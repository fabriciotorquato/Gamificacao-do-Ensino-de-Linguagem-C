using UnityEngine;
using System.Collections;

public class contador_producao_nivel_1 : MonoBehaviour {
    public int cont;
    public GameObject controle, caixa,tela;
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        cont = caixa.GetComponent<exercicio_producao_nivel_1>().contador;
        if (cont == 6)
        {
            tela.SetActive(true);
            tela.GetComponent<Sair>().acertou = true;
            controle.GetComponent<fase_ponto>().pontuacao();
        }
	}
}
