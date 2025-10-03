using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;

public class ShopManager : MonoBehaviour
{
    // fill in inspector with ScriptableObject assets
    public List<ShopItem> shopItems; 

    // content transform of ShopScrollView
    [SerializeField]
    public Transform shopContainer;  
    public GameObject shopItemPrefab;
    public InventoryManager inventoryManager;

    [SerializeField]
    public int playerGold = 100;
    [SerializeField]
    public TextMeshProUGUI goldText;

    void Start()
    {
        UpdateGoldUI();
        PopulateShop();
    }

    void UpdateGoldUI()
    {
        if (goldText != null) 
            goldText.text = $"Gold: {playerGold}";
    }

    void PopulateShop()
    {
        foreach (Transform t in shopContainer) 
            Destroy(t.gameObject);

        foreach (var item in shopItems)
        {
            var obj = Instantiate(shopItemPrefab, shopContainer);
            var ui = obj.GetComponent<ShopItemUI>();
            ui.Setup(item, this);
        }
    }

    public void BuyItem(ShopItem item)
    {
        if (playerGold >= item.price)
        {
            playerGold -= item.price;
            inventoryManager.AddItem(item);
            UpdateGoldUI();
            Debug.Log($"Bought {item.itemName} for {item.price} gold.");
        }
        else
        {
            Debug.Log("Not enough gold!");
        }
    }
}
