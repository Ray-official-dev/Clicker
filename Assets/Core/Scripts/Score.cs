using UnityEngine;
using TMPro;
using System.Collections;

public class Score : MonoBehaviour
{
    public int Value => PlayerPrefs.GetInt("Score");
    public TMP_Text _text;

    private void Start()
    {
        UpdateScore();
    }

    public void AddPassiveClicker(int delayTime) 
    {
        StopAllCoroutines();
        StartCoroutine(PassiveClicker(delayTime));
    }

    private IEnumerator PassiveClicker(int delay)
    {
        while (true) 
        {
            yield return new WaitForSeconds(delay);
            AddScore();
        }
    }

    public void AddScore()
    {
        PlayerPrefs.SetInt("Score", Value + 1);
        UpdateScore();
    }

    private void UpdateScore()
    {
        _text.text = $"Score: {Value}";
    }
}