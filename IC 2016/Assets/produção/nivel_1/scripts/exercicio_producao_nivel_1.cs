using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class exercicio_producao_nivel_1 : MonoBehaviour {
	public string [,]exe = new string[12,2];
	public int numb,ant,contador;
	public Text tela,somar;
	public GameObject fim,caixa;
	public float tempo;

	void Start () {
		exe[0,0]="scanf(\"%d\",&numb)";
		exe[0,1]="correto";
		exe[1,0]="printf(\"%d\",&letra)";
		exe[1,1]="errado";
		exe[2,0]="scanf(\"%d\",numb)";
		exe[2,1]="errado";
		exe[3,0]="scan(\"%d\",&numb)";
		exe[3,1]="errado";
		exe[4,0]="scanf(\"%f\",&float)";
		exe[4,1]="correto";
		exe[5,0]="scanf(\"%d%d\",&numb)";
		exe[5,1]="errado";
		exe[6,0]="scanf(\"%d%d\",&numb,&cont)";
		exe[6,1]="correto";
		exe[7,0]="scanf(\"%c\",&letra)";
		exe[7,1]="correto";
		exe[8,0]="printf(\"%d\",&numb)";
		exe[8,1]="errado";
		exe[9,0]="printf(\"%d\",numb)";
		exe[9,1]="correto";
		exe[10,0]="print(\"%d\",numb)";
		exe[10,1]="errado";
		exe[11,0]="printf(\"%c\",letra)";
		exe[11,1]="correto";
		contador = 0;
		caixa.GetComponent<caixa_producao_nivel_1> ().ligar (true);
		tempo = 5;
        numb = 0;
        ant = 0;
	}

	public void iniciar(){
        ant = numb;
        do
        {
            numb = Random.Range(0, 12);
        } while (numb == ant);

        tela.text = exe[numb, 0];

	}
	void Update () {
		tempo += Time.deltaTime;
		if(tempo>4)
			caixa.GetComponent<caixa_producao_nivel_1> ().ligar (true);
	}
	public void botao(string comando){
		if (comando == exe [numb, 1]) {
			contador++;
			somar.text = contador.ToString ();
			caixa.GetComponent<caixa_producao_nivel_1> ().ligar (false);
			tempo = 0;
		} else {
            fim.GetComponent<Sair>().acertou = false;
			fim.SetActive (true);
           
        }
        if (contador == 6) {
            fim.GetComponent<Sair>().acertou = true;
            fim.SetActive(true);
            
        }
	}

}
