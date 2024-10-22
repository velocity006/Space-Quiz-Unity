using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonInput : MonoBehaviour
{
    public GameObject feed_benar, feed_salah, selesai;

    [SerializeField] Text tjmlSoal;
    [SerializeField] Text tSoal;
    [SerializeField] Text tSkor;
	[SerializeField] Image iSoal;
    [SerializeField] Button ButtonA;
    [SerializeField] Text tButtonA;
    [SerializeField] Button ButtonB;
    [SerializeField] Text tButtonB;
    [SerializeField] Button ButtonC;
    [SerializeField] Text tButtonC;
    [SerializeField] Button ButtonD;
    [SerializeField] Text tButtonD;

    int indeks = 0;
    int skor = 0;
    [SerializeField] int skorTiapSoal = 0;

    [System.Serializable] class soal
    {
        [SerializeField] public Sprite gambarSoal;
        [SerializeField] public string tSoal;
        [SerializeField] public string teksA;
        [SerializeField] public string teksB;
        [SerializeField] public string teksC;
        [SerializeField] public string teksD;
        [SerializeField] public string jawaban;
    }

    [SerializeField] soal[] paketSoal = new soal[5];

    void tampilSoal()
    {
        iSoal.sprite = paketSoal[indeks].gambarSoal;
        tSoal.text = paketSoal[indeks].tSoal;
        tButtonA.text = paketSoal[indeks].teksA;
        tButtonB.text = paketSoal[indeks].teksB;
        tButtonC.text = paketSoal[indeks].teksC;
        tButtonD.text = paketSoal[indeks].teksD;
        tjmlSoal.text = (indeks + 1) + " / " + paketSoal.Length;
        tSkor.text = skor.ToString();
    }
    // Start is called before the first frame update
    void Start()
    {
        tampilSoal();
    }

    public void fTombol(string pilihan)
    {
        if(pilihan == "A")
        {
            if(paketSoal[indeks].teksA == paketSoal[indeks].jawaban)
            {
                feed_benar.SetActive(false);
                feed_benar.SetActive(true);
                feed_salah.SetActive(false);
                skor += skorTiapSoal;
            }
            else
            {
                feed_benar.SetActive(false);
                feed_salah.SetActive(false);
                feed_salah.SetActive(true);
            }
        }
        else if (pilihan == "B")
        {
            if (paketSoal[indeks].teksB == paketSoal[indeks].jawaban)
            {
                feed_benar.SetActive(false);
                feed_benar.SetActive(true);
                feed_salah.SetActive(false);
                skor += skorTiapSoal;
            }
            else
            {
                feed_benar.SetActive(false);
                feed_salah.SetActive(false);
                feed_salah.SetActive(true);
            }
        }
        else if (pilihan == "C")
        {
            if (paketSoal[indeks].teksC == paketSoal[indeks].jawaban)
            {
                feed_benar.SetActive(false);
                feed_benar.SetActive(true);
                feed_salah.SetActive(false);
                skor += skorTiapSoal;
            }
            else
            {
                feed_benar.SetActive(false);
                feed_salah.SetActive(false);
                feed_salah.SetActive(true);
            }
        }
        else if (pilihan == "D")
        {
            if (paketSoal[indeks].teksD == paketSoal[indeks].jawaban)
            {
                feed_benar.SetActive(false);
                feed_benar.SetActive(true);
                feed_salah.SetActive(false);
                skor += skorTiapSoal;
            }
            else
            {
                feed_benar.SetActive(false);
                feed_salah.SetActive(false);
                feed_salah.SetActive(true);
            }
        }

        if (indeks < paketSoal.Length - 1)
        {
            indeks += 1;
        }
        else
        {
            iSoal.enabled = false;
            ButtonA.enabled = false;
            ButtonB.enabled = false;
            ButtonC.enabled = false;
            ButtonD.enabled = false;
            selesai.SetActive(true);
        }

        EventSystem.current.SetSelectedGameObject(null);
        tampilSoal();

    }
	
	void Update()
	{

	}
    
}
