using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestionManager : MonoBehaviour
{
    public TextMeshProUGUI text;
    public ScriptableQuestions questions;
    private int current = 0;

    // Start is called before the first frame update
    void Start()
    {
        nextQuestion();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextQuestion()
    {
        text.text = questions.question[current];
        current++;
    }
}
