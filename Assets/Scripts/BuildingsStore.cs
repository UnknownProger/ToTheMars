using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BuildingStore", menuName = "ScriptableObject/BuildingStore")]
public class BuildingsStore : ScriptableObject 
{
    public Building[] buildings;

}
