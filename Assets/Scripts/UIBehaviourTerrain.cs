using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIBehaviourTerrain : MonoBehaviour
{
    TMP_Text timerText;

    void Start()
    {
        timerText = GameObject.Find("lblTime").GetComponent<TMPro.TMP_Text>();

        StartCoroutine(TimerTick());
    }
    
    IEnumerator TimerTick() {
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
}