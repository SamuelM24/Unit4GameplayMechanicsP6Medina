using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;
public enum PowerUpType { None, Pushback, Rockets, Smash}
public class PowerUp : MonoBehaviour
{
    public PowerUpType powerUpType;
}
