using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class comp_string : MonoBehaviour {
	
	public int i,j,linha_c,r,z,res_if,deslocamento;
	public string ant_i;
	public string[] ant = new string[7];
	public static int gat;
	public static float tempo=0;
	public static char []str=new char[7];
	float py;
    public float h;
    RectTransform rt;
	bool flag;
	public Text vi,resp;
	public Text[] v = new Text[7];
	public Image ui_i;
	public Image[] ui= new Image[7];
	public Color c;
	public GameObject tela,centro;
    public GameObject[] contador_linha = new GameObject[15];

    void Start () {

        str[0] = 'F';
		str[1] = 'a';
		str[2] = 'C';
		str[3] = 'e';
		str[4] = 'N';
		str[5] = 's';
		str[6] = '\0';

        transform.position = contador_linha[0].transform.position;
		i = 0;
		gat = 0;
		linha_c=3;
		v[0]=GameObject.Find ("Vf").GetComponent<Text> ();
		ui[0] = GameObject.Find ("Vf").GetComponentInChildren<Image> ();
		v[1]=GameObject.Find ("Va").GetComponent<Text> ();
		ui[1] = GameObject.Find ("Va").GetComponentInChildren<Image> ();
		v[2]=GameObject.Find ("Vc").GetComponent<Text> ();
		ui[2] = GameObject.Find ("Vc").GetComponentInChildren<Image> ();
		v[3]=GameObject.Find ("Ve").GetComponent<Text> ();
		ui[3] = GameObject.Find ("Ve").GetComponentInChildren<Image> ();
		v[4]=GameObject.Find ("Vn").GetComponent<Text> ();
		ui[4] = GameObject.Find ("Vn").GetComponentInChildren<Image> ();
		v[5]=GameObject.Find ("Vs").GetComponent<Text> ();
		ui[5]= GameObject.Find ("Vs").GetComponentInChildren<Image> ();
		v[6]=GameObject.Find ("V0").GetComponent<Text> ();
		ui[6] = GameObject.Find ("V0").GetComponentInChildren<Image> ();
		vi=GameObject.Find ("Vi").GetComponent<Text> ();
		ui_i = GameObject.Find ("Vi").GetComponentInChildren<Image> ();
		resp=GameObject.Find ("resp").GetComponent<Text> ();
		c = ui_i.color;
		deslocamento = 1;
		flag = true;
		for(j=0;j<7;j++)
			ant[j] = v[j].text;
		ant_i = vi.text;
	}

	void Update () {
		if (gat == 1) {
			if (linha_c == 3 && flag==true) {
                transform.position = contador_linha[3].transform.position;
                StartCoroutine("Tempo");
				flag = false;
			}
			if (linha_c == 4 && flag == true) {
				i = 0;
				vi.text = i.ToString();
				flag = false;
			}
			if (linha_c == 5 && flag == true) {
				v[0].text = "F";
				v[1].text = "a";
				v[2].text = "C";
				v[3].text = "e";
				v[4].text = "N";
				v[5].text = "s";
				v[6].text = "\\0";
				flag = false;
			} else if (linha_c == 6 && flag == true) {
				vi.text = i.ToString ();
				flag = false;
				if (i >= 6)
					deslocamento = 4;
			} else if (linha_c == 7 && flag == true) {
				res_if = tradutor_C_string.i;
					if(res_if==0){
						if(str[i]>='a' && str[i]<='z')
							deslocamento=1;
						else
							deslocamento=2;
					}
					if(res_if==1){
						if(str[i]>='A' && str[i]<='Z')
							deslocamento=1;
						else
							deslocamento=2;
					}

			} else if (linha_c == 8 && flag == true) {
				
				if (res_if == 0) {
					str [i] = System.Char.ToUpper (str [i]);
					v[i].text = str[i].ToString();
				} else {
					str [i] = System.Char.ToLower (str [i]);
					v[i].text = str[i].ToString();
				}
			} else if (linha_c == 9 && flag == true) {
				i++;
				vi.text =i.ToString ();
				deslocamento=-3;
				flag = false;
			} else if (linha_c == 11 && flag == true) {
				if (res_if == 0)
					resp.text="FACENS";
				else
					resp.text="facens";
				flag = false;
			} else if (linha_c == 12 && flag == true) {
				resp.text = resp.text + "\nProcess returned 0";
				flag = false;
			} else if (linha_c == 13 && flag == true) {
				StopCoroutine ("Tempo");
				flag = true;
				gat = 0;
				transform.position = new Vector3 (transform.position.x,1800.1f,transform.position.z);
				linha_c = 3;
			}

			tempo+= Time.deltaTime;
			c.a = 0;
			if (tempo >= 3) {
				tempo = 0;
				ui_i.color = c;
				ui [0].color = c;
				ui [1].color = c;
				ui [2].color = c;
				ui [3].color = c;
				ui [4].color = c;
				ui [5].color = c;
				ui [6].color = c;
			}
			if (ant_i != vi.text) {
				c.a = (float)0.40;
				tempo = 0;
				ui_i.color = c;
				ant_i = vi.text;
			}
			for(j=0;j<7;j++){
				if (ant[j] != v[j].text) {
					c.a = (float)0.40;
					tempo = 0;
					ui[j].color = c;
					ant[j] = v[j].text;
				}
			}

		}
	}
	public IEnumerator Tempo()
	{
		while(true)
		{
			if(linha_c==13)
				tela.SetActive (true);
			yield return new WaitForSeconds(2);
            linha_c =linha_c+deslocamento;
			if(linha_c!=13)
                transform.position = contador_linha[linha_c].transform.position;
            
			Debug.Log ("linha: "+linha_c.ToString());
			flag = true;
			if (deslocamento != 1)
				deslocamento = 1;
		}
	}
}
