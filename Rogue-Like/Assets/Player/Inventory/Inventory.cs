using UnityEngine;

[CreateAssetMenu(fileName = "Inventory", menuName = "ScriptableObjects/InventoryScriptableObject", order = 6)]
public class Inventory : ScriptableObject
{
    public CollectiblesEventChannel collectiblesEventChannel;

    [SerializeField] private int coinTotal;

    public void OnEnable()
    {
        collectiblesEventChannel.onAddCoin += AddCoin;
    }

    public void OnDisable()
    {
        collectiblesEventChannel.onAddCoin -= AddCoin;
    }

    private void AddCoin()
    {
        Debug.Log("Add coin to stats"); 
        coinTotal++;
    }
}
