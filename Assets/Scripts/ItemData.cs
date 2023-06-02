using UnityEngine;
using NaughtyAttributes;

[CreateAssetMenu(fileName = "new item", menuName = "Data/New item", order = 61)]
public class ItemData : ScriptableObject
{
    [ShowAssetPreview] public Sprite Img;
    public int Count;
}
