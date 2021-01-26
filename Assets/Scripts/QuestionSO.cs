using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class QuestionSO : ScriptableObject
{
    public string text;

    public Sprite sprite;

    public string[] answers;
    public int correctAnswer;
}

