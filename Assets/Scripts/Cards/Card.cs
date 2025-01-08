using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI nameText;
    [SerializeField] TextMeshProUGUI numberText;
    [SerializeField] Image icon;
    [SerializeField] TextMeshProUGUI descriptionText;

    public void Set(CardBase cardBase)
    {
        nameText.text = cardBase.Name;
        numberText.text = cardBase.Number.ToString();
        icon.sprite = cardBase.Icon;
        descriptionText.text = cardBase.Description;
    }
}
