using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyHealthView : MonoBehaviour
{
    [SerializeField] private EnemyHealthController _healthController;
    [SerializeField] private TMP_Text _enemyHealthText;
    void Update()
    {
        _enemyHealthText.text = "Health: " + _healthController.HP;
    }
}
