using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIBehaviour : MonoBehaviour
{
    TMP_Text headText;
    TMP_Text timerText;
    int nbCats = 0;

    void Start()
    {
        headText = GameObject.Find("lblCats").GetComponent<TMPro.TMP_Text>();
        timerText = GameObject.Find("lblTime").GetComponent<TMPro.TMP_Text>();

        StartCoroutine(TimerTick());
    }

    IEnumerator TimerTick()
    {
        while (GameVariables.currentTime > 0)
        {
            yield return new WaitForSeconds(1);
            GameVariables.currentTime--;
            timerText.text = "Time :" + GameVariables.currentTime.ToString();
        }

        SceneManager.LoadScene("dragonScene");
    }

    void Update()
    {
    }

    public void AddHit()
    {
        nbCats++;
        headText.text = "BobHeads : " + nbCats;
        if (nbCats >= 5)
            SceneManager.LoadScene("TerrainScene");
    }
}