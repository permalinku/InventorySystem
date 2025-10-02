using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Shop/Item")]
public class ShopItem : ScriptableObject
{
    // the item name
    public string itemName;

    // the item icon
    public Sprite icon;

    // the item description
    [TextArea] 
    public string description;

    // the item price
    public int price;
}
