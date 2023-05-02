using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowEnemySprite : MonoBehaviour
{
    [SerializeField] private Transform enemy;

    private void Update()
    {
        transform.position = new Vector3(enemy.position.x, enemy.position.y, enemy.position.z);
    }
}
