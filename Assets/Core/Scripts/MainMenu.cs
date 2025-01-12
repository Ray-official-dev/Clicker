using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private int _score;
    [SerializeField] private TMP_Text _text;


    public void OnClicked()
    {
        _score++;
        _text.text = _score.ToString();
    }
}
