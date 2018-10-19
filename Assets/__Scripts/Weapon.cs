using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponType {
    none, // The default / no weapon 
    blaster, // A simple blaster 
    spread, // Two shots simultaneously 
    phaser, // [NI] Shots that move in waves 
    missile, // [NI] Homing missiles 
    laser, // [NI] Damage over time 
    shield // Raise shieldLevel 
}

/// < summary > 
/// The WeaponDefinition class allows you to set the properties 
/// of a specific weapon in the Inspector. The Main class has 
/// an array of WeaponDefinitions that makes this possible. 
/// </ summary > 
[System.Serializable] // a 
public class WeaponDefinition { // b 
    public WeaponType type = WeaponType.none;
    public string letter; // Letter to show on the power-up 
    public Color color = Color.white; // Color of Collar & power-up 
    public GameObject projectilePrefab; // Prefab for projectiles 
    public Color projectileColor = Color.white;
    public float damageOnHit = 0; // Amount of damage caused 
    public float continuousDamage = 0; // Damage per second (Laser) 
    public float delayBetweenShots = 0; public
}

public class Weapon : MonoBehaviour { 
      // The Weapon class will be filled in later in the chapter. 
}


