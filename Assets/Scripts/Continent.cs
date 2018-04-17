using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Continent : MonoBehaviour
{
    public enum CONTINENT_TYPE {ICE, SAND, FOREST};
    public CONTINENT_TYPE continentType;
    public Transform[] buildingPlaces;
}
