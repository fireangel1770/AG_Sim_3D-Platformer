using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player Stats")]
public class PlayerStats : ScriptableObject
{
    public float health;
    public float maxHealth;
    public float moveSpeed;
    public float jumpForce;
    public float gravity;
}
