using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Building
{
    public string name;
    public BuildingUpgrade[] upgrades;
}

[System.Serializable]
public class BuildingUpgrade
{
    public int price;
    public int sinceYear;
    public GameObject prefab;
}
