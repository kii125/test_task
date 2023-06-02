using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemCell : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Image _cellImage;

    public int Count
    {
        set
        {
            _text.text = value.ToString();
        }
    }

    public Sprite ImageCell
    {
        set
        {
            _cellImage.sprite = value;
        }
    }
    
}
