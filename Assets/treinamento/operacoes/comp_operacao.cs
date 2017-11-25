using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class comp_operacao : MonoBehaviour {
	public int i,j,res,linha_c,r,z,res_if,deslocamento,linha_cv,linha_cvv,a,cc,b;
	public string ant_a,ant_b,ant_c;
	public int op1, op2, op3, gat;
	public static float tempo=0;
	public GameObject scanb,scana,mais,menos,mult;
	public GameObject f1_0, f1_1, f1_2, f2_0, f2_1, f2_2,compver,centro;
	float cv_px;
    public float h;
    RectTransform rt;
	bool flag;
	public Text va, vb,vc,resp;
	public Image ui_a,ui_b,ui_c;
	public Color c;
	public GameObject tela;
    public GameObject[] contador_linha = new GameObject[15];
    void Start () {
        rt = (RectTransform)centro.transform;

        h = rt.rect.height;
        h /= 12;

        linha_cv = 0;
		cv_px = compver.transform.position.x;
        transform.position = contador_linha[0].transform.position;
		res = 0;
		gat = 0;
		linha_c=5;

		vc=GameObject.Find ("vc").GetComponent<Text> ();
		ui_c = GameObject.Find ("vc").GetComponentInChildren<Image> ();
		va=GameObject.Find ("va").GetComponent<Text> ();
		ui_a = GameObject.Find ("va").GetComponentInChildren<Image> ();
		c = ui_a.color;
		vb=GameObject.Find ("vb").GetComponent<Text> ();
		ui_b = GameObject.Find ("vb").GetComponentInChildren<Image> ();

		resp=GameObject.Find ("resp").GetComponent<Text> ();

		deslocamento = 1;
		flag = true;
	}

	void Update () {
		if (gat == 1) {
			if (linha_c == 5 && flag==true) {
				
				transform.position = contador_linha[4].transform.position;
                va.text = "Lixo de Memoria";
				ant_a = va.text;
				vb.text = "Lixo de Memoria";
				ant_b = vb.text;
				vc.text = "Lixo de Memoria";
				ant_c = vc.text;


				StartCoroutine("Tempo");
				flag = false;
			}
			if (linha_c == 6 && flag == true) {
				if (scana.GetComponent<mover_botao> ().cod == 1) {
					a= Random.Range (0, 9);
					va.text = a.ToString ();
				} else {
					b= Random.Range (0, 9);
					vb.text = b.ToString ();
				}
				flag = false;
			} else if (linha_c == 7 && flag == true) {
				if (scana.GetComponent<mover_botao> ().cod == 2) {
					a= Random.Range (0, 9);
					va.text = a.ToString ();
				} else {
					b= Random.Range (0, 9);
					vb.text = b.ToString ();
				}
				flag = false;
			} else if (linha_c == 8 && flag == true) {
				if (mais.GetComponent<mover_botao> ().cod == 3)
					cc = a + b;
				else if (menos.GetComponent<mover_botao> ().cod == 3)
					cc = b - a; 
				else 
					cc = a * b; 
				vc.text = cc.ToString ();
				flag = false;
			} else if (linha_c == 9 && flag == true) {
				resp.text = "c = " + cc.ToString();
				flag = false;
			} else if (linha_c == 10 && flag == true) {
				resp.text +=  "\nProcess returned 0";
				flag = false;
			} else if (linha_c == 12 && flag == true) {
				StopCoroutine ("Tempo");
				flag = true;
				gat = 0;
                transform.position= contador_linha[0].transform.position;
                linha_c = 3;
			}

			tempo+= Time.deltaTime;
			c.a = 0;
			if (tempo >= 3) {
				tempo = 0;
				ui_a.color = c;
				ui_b.color = c;
				ui_c.color = c;
			}
			if (ant_a != va.text) {
				c.a = (float)0.40;
				tempo = 0;
				ui_a.color = c;
				ant_a = va.text;
			}
			if (ant_b != vb.text) {
				c.a = (float)0.40;
				tempo = 0;
				ui_b.color = c;
				ant_b = vb.text;
			}
			if (ant_c != vc.text) {
				c.a = (float)0.40;
				tempo = 0;
				ui_c.color = c;
				ant_c = vc.text;
			}

		}
	}
	public IEnumerator Tempo2()
	{
		while (true) {
			yield return new WaitForSeconds (3);
			linha_cv++;
			if (linha_cv == 4)
				compver.transform.position = f1_1.transform.position;
			else if (linha_cv == 5) {
				compver.transform.position = new Vector3 (cv_px, transform.position.y, transform.position.z);
				linha_cv = 1;
				StartCoroutine ("Tempo");
				StopCoroutine ("Tempo2");
			}
		}

	}
	public IEnumerator Tempo3()
	{
		while (true) {
			yield return new WaitForSeconds (3);
			linha_cvv++;
			if (linha_cvv == 4)
				compver.transform.position = f2_1.transform.position;
			else if (linha_cvv == 5) {
				compver.transform.position = new Vector3 (cv_px, transform.position.y, transform.position.z);
				linha_cvv = 1;
				StartCoroutine ("Tempo");
				StopCoroutine ("Tempo3");
			}
		}

	}

	public IEnumerator Tempo()
	{
		while(true)
		{
			if(linha_c==12)
				tela.SetActive (true);
			yield return new WaitForSeconds(3);
			if(linha_c!=12)
				transform.position = contador_linha[linha_c].transform.position;
            linha_c =linha_c+deslocamento;
			Debug.Log ("linha: "+linha_c.ToString());
			flag = true;
			if (deslocamento != 1)
				deslocamento = 1;
		}
	}
}
