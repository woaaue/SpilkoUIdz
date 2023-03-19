using TMPro;
using UnityEngine;

public class NamePlayer : MonoBehaviour
{
    [SerializeField] private TextMeshPro _playerName;

    private TMP_InputField _text;

    private void Start()
    {
        _text = GetComponent<TMP_InputField>();
    }

    void Update()
    {
        if (_text != null)
            _playerName.text = _text.text;
    }
}
