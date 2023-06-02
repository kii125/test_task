using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BuyWindow : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _header;
    [SerializeField] private TextMeshProUGUI _description;
    [SerializeField] private TextMeshProUGUI _cost;
    [SerializeField] private TextMeshProUGUI _oldCost;
    [SerializeField] private TextMeshProUGUI _discountText;
    [SerializeField] private Image _image;
    [SerializeField] private GameObject _discount;
    [SerializeField] private GameObject _itemGroup;
    [SerializeField] private GameObject _itemCellPrefab;
    
    public void init(BuyWindowData data, List<ItemData> items)
    {
        _header.text = data.Header;
        _description.text = data.Description;
        _image.sprite = data.KitImg;
        if (data.IsHaveDiscount)
        {
            _discount.SetActive(true);
            _oldCost.text = data.Cost.ToString() + "$";
            _cost.text = data.Discount.ToString() + "$";
            _discountText.text = ((data.Discount / data.Cost) * 100).ToString() + "%";
        }
        else
        {
            _cost.text = data.Cost.ToString() + "$";
        }

        for (int i = 0; i < items.Count; i++)
        {
            GameObject newItem = Instantiate(_itemCellPrefab, _itemGroup.transform);
            newItem.GetComponent<ItemCell>().ImageCell = items[i].Img;
            newItem.GetComponent<ItemCell>().Count = items[i].Count;
        }
    }

    public void clear()
    {
        _header.text = "";
        _description.text = "";
        _image.sprite = null;
        _discount.SetActive(false);
        _oldCost.text = "";
        _cost.text = "";
        _discountText.text = "";
        
        for (int i = _itemGroup.transform.childCount - 1; i >= 0; i--) {
            DestroyImmediate(_itemGroup.transform.GetChild(i).gameObject);
        }
    }
}
