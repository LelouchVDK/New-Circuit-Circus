using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SusScoring : MonoBehaviour
{
    int questionNumber = 0;
    [SerializeField] TMP_Text videre;

    [SerializeField] TMP_Text question;

    [SerializeField] Slider slider;

    // [SerializeField] Canvas menu;

    string[] questions = {
    "Det var svært at finde ud af hvad jeg skulle gøre",
    "Det var nemt at komme i gang",
    "Banerne var for langsomme",
    "Banerne hjalp til min forståelse af hvordan et elektrisk kredsløb virker",
    "Der var et få udvalg af baner",
    "Banerne føltes som at være i en rigtig rutsjebane",
    "Banerne gjorde mig forvirret",
    "Jeg fik lyst til at prøve flere gange",
    "Der var tidspunkter hvor jeg kedede mig"
    };
    float susScore = 0;
    public void NextQuestion()
    {
        if (videre.text == "Afslut")
        {
            Application.Quit();
        }
        if (questionNumber == 8)
        {
            susScore *= 2.5f;
            videre.text = "Afslut";
            question.text = susScore.ToString();
        }


        questionNumber++;


        question.text = questions[questionNumber];
        Debug.Log("Yees0");
        if (questionNumber % 2 == 0)
        { susScore += (int)slider.value - 1; }
        else
        { susScore += 5 - (int)slider.value; }

    }
    /*
    void Update()
    {
        if (Keyboard.current.qKey.wasPressedThisFrame)
        {
            NextQuestion();
        }
    }*/
}