using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class BuyWindowInit : MonoBehaviour
{
    [SerializeField] private List<ItemData> _items;
    [SerializeField] private InputField _inputField;
    [SerializeField] private BuyWindow _buyWindow;
    public BuyWindowData WindowData;

    public void initBuyWindow()
    {
        ItemData[] items = new ItemData[Mathf.Clamp(int.Parse(_inputField.text), 3, 6)];
        for (int i = 0; i < items.Length; i++)
        {
            items[i] = _items[Random.Range(0,_items.Count)];
        }
        _buyWindow.init(WindowData,items.ToList());
    }
}
