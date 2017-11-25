using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class comp : MonoBehaviour
{
    public int i, j, res, linha_c, r, z, res_if, deslocamento, linha_cv, linha_cvv;
    public string ant_i, ant_j, ant_res;
    public static int op1, op2, op3, gat;
    public static float tempo = 0;
    public GameObject f1_0, f1_1, f1_2, f2_0, f2_1, f2_2, compver, campo_comp, linha, numb;
    float cv_px;
    bool flag;
    public Text vi, vj, vc, resp;
    public Image ui_i, ui_j, ui_res;
    public Color c;
    public GameObject tela;
    public GameObject[] contador_linha = new GameObject[15];

    void Start()
    {

        linha_cv = 0;
        cv_px = compver.transform.position.x;
        transform.position = new Vector3(contador_linha[0].transform.position.x, contador_linha[0].transform.position.y);
        res = 0;
        gat = 0;
        linha_c = 3;
        vc = GameObject.Find("Vc").GetComponent<Text>();
        ui_res = GameObject.Find("Vc").GetComponentInChildren<Image>();
        vi = GameObject.Find("Vi").GetComponent<Text>();
        ui_i = GameObject.Find("Vi").GetComponentInChildren<Image>();
        c = ui_i.color;
        vj = GameObject.Find("Vj").GetComponent<Text>();
        ui_j = GameObject.Find("Vj").GetComponentInChildren<Image>();
        resp = GameObject.Find("resp").GetComponent<Text>();
        i = 0;
        j = 0;
        op1 = 8;
        op3 = 8;
        op2 = 8;
        deslocamento = 1;
        flag = true;
    }

    void Update()
    {
        if (gat == 1)
        {
            if (linha_c == 3 && flag == true)
            {
                transform.position = contador_linha[0].transform.position;
                vc.text = "";
                ant_res = vc.text;
                vi.text = "";
                ant_i = vi.text;
                vj.text = "";
                ant_j = vj.text;
                resp.text = "";
                i = 0;
                j = 0;
                res = 0;
                StartCoroutine("Tempo");
                flag = false;
            }
            if (linha_c == 4 && flag == true)
            {
                vc.text = "0";
                flag = false;
            }
            else if (linha_c == 6 && flag == true)
            {
                if (linha_cv == 0)
                {
                    compver.transform.position = f1_0.transform.position;
                    StopCoroutine("Tempo");
                    linha_cv = 1;
                    StartCoroutine("Tempo2");
                    vi.text = i.ToString();
                }
                else if (linha_cv == 1)
                {
                    linha_cvv = 0;
                    StopCoroutine("Tempo");
                    compver.transform.position = f1_2.transform.position;
                    StartCoroutine("Tempo2");
                    vi.text = i.ToString();
                }
                flag = false;
                if (i >= 3)
                    deslocamento = 7;
            }
            else if (linha_c == 7 && flag == true)
            {
                if (linha_cvv == 0)
                {
                    compver.transform.position = f2_0.transform.position;
                    StopCoroutine("Tempo");
                    linha_cvv = 1;
                    StartCoroutine("Tempo3");
                    vj.text = j.ToString();
                }
                else if (linha_cvv == 1)
                {
                    StopCoroutine("Tempo");
                    compver.transform.position = f2_2.transform.position;
                    StartCoroutine("Tempo3");
                    vj.text = j.ToString();
                }
                flag = false;
                if (j >= 3)
                    deslocamento = 5;
            }
            else if (linha_c == 8 && flag == true)
            {
                res_if = analise_if();
                if (res_if != 0)
                {
                    deslocamento = 2;
                }
            }
            else if (linha_c == 9 && flag == true)
            {
                res = res + campo_comp.GetComponent<tradutor_C>().numb[i, j];
                vc.text = res.ToString();
                flag = false;
            }
            else if (linha_c == 11 && flag == true)
            {
                j++;
                deslocamento = -4;
                flag = false;
            }
            else if (linha_c == 12 && flag == true)
            {
                i++;
                j = 0;
                deslocamento = -6;
                flag = false;
            }
            else if (linha_c == 13 && flag == true)
            {
                resp.text = "soma = " + res;
                flag = false;
            }
            else if (linha_c == 14 && flag == true)
            {
                resp.text = resp.text + "\nProcess returned 0";
                StopCoroutine("Tempo");
                flag = true;
                gat = 0;
                transform.position = contador_linha[0].transform.position;
                linha_c = 3;
            }

            tempo += Time.deltaTime;
            c.a = 0;
            if (tempo >= 3)
            {
                tempo = 0;
                ui_i.color = c;
                ui_j.color = c;
                ui_res.color = c;
            }
            if (ant_i != vi.text)
            {
                c.a = (float)0.40;
                tempo = 0;
                ui_i.color = c;
                ant_i = vi.text;
            }
            if (ant_j != vj.text)
            {
                c.a = (float)0.40;
                tempo = 0;
                ui_j.color = c;
                ant_j = vj.text;
            }
            if (ant_res != vc.text)
            {
                c.a = (float)0.40;
                tempo = 0;
                ui_res.color = c;
                ant_res = vc.text;
            }

        }
    }
    public IEnumerator Tempo2()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            linha_cv++;
            if (linha_cv == 2)
                compver.transform.position = f1_1.transform.position;
            else if (linha_cv == 3)
            {
                compver.transform.position = new Vector3(cv_px, transform.position.y, transform.position.z);
                linha_cv = 1;
                StartCoroutine("Tempo");
                StopCoroutine("Tempo2");
            }
        }

    }
    public IEnumerator Tempo3()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            linha_cvv++;
            if (linha_cvv == 2)
                compver.transform.position = f2_1.transform.position;
            else if (linha_cvv == 3)
            {
                compver.transform.position = new Vector3(cv_px, transform.position.y, transform.position.z);
                linha_cvv = 1;
                StartCoroutine("Tempo");
                StopCoroutine("Tempo3");
            }
        }

    }

    public IEnumerator Tempo()
    {
        while (true)
        {
            if (linha_c == 6 && linha_cv == 1)
                compver.transform.position = new Vector3(cv_px, transform.position.y, transform.position.z);
            if (linha_c == 7 && linha_cvv == 1)
                compver.transform.position = new Vector3(cv_px, transform.position.y, transform.position.z);
            if (linha_c == 14)
                tela.SetActive(true);
            yield return new WaitForSeconds(2);
            linha_c = linha_c + deslocamento;
            if (linha_c != 14)
                transform.position = contador_linha[linha_c].transform.position;

            Debug.Log("linha: " + linha_c.ToString());
            flag = true;
            if (deslocamento != 1)
                deslocamento = 1;
        }
    }
    public int analise_if()
    {
        if (op1 == 0)
            r = 0;
        else if (op1 == 1)
            r = 1;
        else if (op1 == 2)
            r = 2;
        else if (op1 == 3)
            r = i;
        else if (op1 == 4)
            r = j;
        if (op3 == 0)
            z = 0;
        else if (op3 == 1)
            z = 1;
        else if (op3 == 2)
            z = 2;
        else if (op3 == 3)
            z = i;
        else if (op3 == 4)
            z = j;
        if (op2 == 5)
        {
            if (r == z)
                return 0;
            else
                return 1;
        }
        else if (op2 == 6)

        {
            if (r != z)
                return 0;
            else
                return 1;
        }

        return 3;
    }
}
