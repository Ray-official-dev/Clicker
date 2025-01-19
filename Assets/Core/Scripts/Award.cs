using TMPro;
using UnityEngine;

public class Award : MonoBehaviour
{
    [SerializeField] private int _requiredScore;
    [SerializeField] private string _index;
    [SerializeField] private int _delayTime;

    [SerializeField] private Score _score;
    [SerializeField] private TMP_Text _text;

    [SerializeField] private GameObject _lockSprite;
    [SerializeField] private GameObject _unlockSprite;

    private void OnEnable()
    {
        _text.text = $"{_score.Value} / {_requiredScore}";

        if (_score.Value < _requiredScore)
            return;

        if (PlayerPrefs.HasKey(_index))
            gameObject.SetActive(false);

        _lockSprite.SetActive(false);
        _unlockSprite.SetActive(true);
    }

    public void OnClicked()
    {
        if (_score.Value < _requiredScore)
            return;

        if (PlayerPrefs.HasKey(_index))
            return;

        _score.AddPassiveClicker(_delayTime);
        PlayerPrefs.SetString(_index, "true");
        gameObject.SetActive(false);
    }
}
