using UnityEngine;

[CreateAssetMenu(fileName = "New PlayerMovementSettings", menuName = "PlayerMovementSettings")] 
public class PlayerMovementSettings : ScriptableObject
{
    public float moveSpeed;

    public float jumpHeight;

    public float downGravity;
}
