using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "CollectiblesEventChannel", menuName = "ScriptableObjects/CollectiblesEventChannelScriptableObject", order = 5)]
public class CollectiblesEventChannel : ScriptableObject
{
    public UnityAction onAddCoin;

    public void RaiseEvent()
    {
        onAddCoin?.Invoke();
    }
}
