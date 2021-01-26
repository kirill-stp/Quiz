using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text[] buttonText;
    public Text titleText;
    public Text questionText;

    public Button[] buttons;
    public Button fifryButoon;

    public Image questionImage;
    public QuestionSO[] questions;

    public SceneLoader sceneLoader;

    int currentQuestion = 0;

    public PlayerSo player;


    // Start is called before the first frame update
    void Start()
    {
        UpdateUI();
        player.playerScore = 0;
    }

    public void NextQuestion(int i)
    {
        CheckQuestion(i, questions[currentQuestion]);
        currentQuestion++;
        if (currentQuestion == questions.Length)
        {
            sceneLoader.LoadEndScene();
            return;
        }
        UpdateUI();

        for (int j = 0; j < buttons.Length; j++)
        {
            buttons[j].interactable = true;
        }
    }

    void CheckQuestion(int i,QuestionSO question)
    {
        if (i == question.correctAnswer)
        {
            player.playerScore ++;
        }
    }
    void UpdateUI()
    {
        titleText.text = "Вопрос № " + (currentQuestion + 1).ToString();
        questionText.text = questions[currentQuestion].text;
        questionImage.sprite = questions[currentQuestion].sprite;
        for (int i = 0; i < buttonText.Length; i++)
        {
            buttonText[i].text = questions[currentQuestion].answers[i];
        }
    }

    public void FiftyFifty()
    {
        int savedButtons = 0;
        int correct = questions[currentQuestion].correctAnswer;
        for (int i = 0; i < buttons.Length; i++)
        {
            if (savedButtons < 1)
            {
                savedButtons ++;
            }
            else if( i != correct)
            {
                buttons[i].interactable = false;
            }
        }

        fifryButoon.interactable = false;
    }
}
