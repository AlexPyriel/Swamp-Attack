using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextWave : MonoBehaviour
{
    [SerializeField] private Spawner _spawner;
    [SerializeField] private Button  _nextWaveButton;

    private void OnEnable()
    {
        _spawner.AllEnemiesSpawned += OnAllEnemySpawned;
        _nextWaveButton.onClick.AddListener(OnNextWaveButtonClicked);
    }

    private void OnDisable()
    {
        _spawner.AllEnemiesSpawned -= OnAllEnemySpawned;
        _nextWaveButton.onClick.RemoveListener(OnNextWaveButtonClicked);
    }

    private void OnAllEnemySpawned()
    {
        _nextWaveButton.gameObject.SetActive(true);
    }

    public void OnNextWaveButtonClicked()
    {
        _spawner.NextWave();
        _nextWaveButton.gameObject.SetActive(false);
    }
}
