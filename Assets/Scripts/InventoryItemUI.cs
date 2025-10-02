using UnityEngine;
using UnityEngine.UI;

using TMPro;

public class InventoryItemUI : MonoBehaviour
{
    public Image icon;
    public TextMeshProUGUI nameText;

    public void Setup(ShopItem item)
    {
        icon.sprite = item.icon;
        nameText.text = item.itemName;
    }
}