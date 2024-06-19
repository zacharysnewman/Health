using TMPro;
using UnityEngine;

public class SetText : MonoBehaviour
{
    private TMP_Text text;

    private void Awake()
    {
        text = GetComponent<TMP_Text>();
    }

    public void Set(bool value)
    {
        text.text = $"{value}";
    }
}
