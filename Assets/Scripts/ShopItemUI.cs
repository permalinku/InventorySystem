using UnityEngine;
using UnityEngine.UI;

using TMPro;

public class ShopItemUI : MonoBehaviour
{
    public Image icon;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI priceText;
    public Button buyButton;

    private ShopItem item;
    private ShopManager shopManager;

    public void Setup(ShopItem item, ShopManager manager)
    {
        this.item = item;
        shopManager = manager;

        icon.sprite = item.icon;
        nameText.text = item.itemName;
        descriptionText.text = item.description;
        priceText.text = item.price.ToString();

        buyButton.onClick.RemoveAllListeners();
        buyButton.onClick.AddListener(OnBuyClicked);
    }

    void OnBuyClicked()
    {
        shopManager.BuyItem(item);
    }
}
