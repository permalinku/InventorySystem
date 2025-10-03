using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    // assign the content transform of InventoryScrollView
    public Transform inventoryContainer; 
    public GameObject inventoryItemPrefab;

    private List<ShopItem> ownedItems = new List<ShopItem>();

    public void AddItem(ShopItem item)
    {
        ownedItems.Add(item);
        RefreshUI();
    }

    void RefreshUI()
    {
        foreach (Transform t in inventoryContainer) 
            Destroy(t.gameObject);

        foreach (var item in ownedItems)
        {
            var obj = Instantiate(inventoryItemPrefab, inventoryContainer);
            var ui = obj.GetComponent<InventoryItemUI>();
            ui.Setup(item);
        }
    }
}
