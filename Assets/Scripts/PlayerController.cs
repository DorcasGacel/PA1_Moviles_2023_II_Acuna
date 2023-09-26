using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
[CreateAssetMenu(fileName = "ControlPlayer", menuName = "ScriptableObjects/Personajes")]
public class PlayerController : ScriptableObject
{
    public GameObject characterPref;
    public Sprite image;
    public string name;
    public float life = 3f;
    public int PlayerVelocity = 0;
    public int score = 0;
}
