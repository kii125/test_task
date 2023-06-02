using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

[CreateAssetMenu(fileName = "new buy window", menuName = "Data/New buy window", order = 61)]
public class BuyWindowData : ScriptableObject
{
    private const string infoFolder = "Info";
    [Foldout(infoFolder)] public string Header;
    [Foldout(infoFolder)] public string Description;

    [ShowAssetPreview] public Sprite KitImg;

    private const string costFolder = "Cost";
    [Foldout(costFolder)] public float Cost;
    [Foldout(costFolder)] public bool IsHaveDiscount;
    [Foldout(costFolder), EnableIf(nameof(IsHaveDiscount))]public float Discount;
}
