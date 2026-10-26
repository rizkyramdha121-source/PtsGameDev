using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour, IPointerClickHandler
{
    // Item Data
    public string itemName;
    public int itemQuantity;
    public Sprite itemIcon;
    public bool isFull;

    // Item Slot
    [SerializeField] private TMP_Text quantityText;
    [SerializeField] private Image itemImage;
    [SerializeField] private int MaxStackSize = 99;
    
    // Slot management
    [SerializeField] public GameObject SelectedPanel;
    public bool isItemSelected;
    
    public InventoryManager inventoryManager;

    public void Awake()
    {
       inventoryManager = FindAnyObjectByType<InventoryManager>();
    }

   public void AddItem(ItemDetails item)
    {
        itemName = item.ItemName;
        //itemQuantity = item.Quantity;
        itemIcon = item.ItemIcon;
        isFull = true;
        AddQuantity(item.Quantity);

        // quantityText.text = itemQuantity.ToString();
        // quantityText.enabled = true;
        // itemImage.sprite = itemIcon;
    }

    public bool CanStackWith(string otherItemName)
    {
        return !isFull && itemName == otherItemName;
    }
    
    public void AddQuantity(int amount)
    {
        itemQuantity += amount;
        isFull = itemQuantity >= MaxStackSize;

        quantityText.text = itemQuantity.ToString();
        quantityText.enabled = true;
        itemImage.sprite = itemIcon;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            RightClick();
            // Implement logic for right-clicking on the item slot, such as using or dropping the item.
        }

        if (eventData.button == PointerEventData.InputButton.Left)
        {
            LeftClick();
            // Implement logic for right-clicking on the item slot, such as using or dropping the item.
        }
    }

    public void RightClick()
    {
        // Implement logic for right-clicking on the item slot, such as using or dropping the item.
        Debug.Log("Right clicked");
    }

    public void LeftClick()
    {
        inventoryManager.DeselectAllSlots();
        isItemSelected = true;
        SelectedPanel.SetActive(true);
        Debug.Log("Left clicked");
    }
}
