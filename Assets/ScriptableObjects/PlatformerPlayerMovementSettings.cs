using UnityEngine;

[CreateAssetMenu(fileName = "New PlayerMovementSettings", menuName = "PlayerMovementSettings")] 
public class PlatformerPlayerMovementSettings : ScriptableObject
{
    public float moveSpeed;

    public float jumpHeight;

    public float downGravity;
}
