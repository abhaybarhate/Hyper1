using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="Item", menuName = "Item/Create New Item", order = 1)]
public class Item : ScriptableObject{
    
    public GameObject ItemPrefab;
    public ItemType itemType;
    public float positiveHealthAmount;
    public float positiveSpeedAmount;
    public float negativeHealthAmount;
    public float negativeSpeedAmount;

    public void Spawn(Vector3 spawnPosition) {
        Instantiate(ItemPrefab, spawnPosition, Quaternion.identity);
    }

    

}
