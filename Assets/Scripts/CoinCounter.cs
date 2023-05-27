using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{

    private GameObject[] _coins;

    private int _activeCoins = 0;
    private int _totalCoins = 0;

    [SerializeField] private TextMeshProUGUI _coinCounterText;

    private string _originalCoinCounterText;

    private int _playerCoinCount;

    // Start is called before the first frame update
    void Start()
    {
        _totalCoins = GameObject.FindGameObjectsWithTag("Coin").Length;
        _originalCoinCounterText = _coinCounterText.text;

    }

    // Update is called once per frame
    void Update()
    {
        _activeCoins = GameObject.FindGameObjectsWithTag("Coin").Length;
        _playerCoinCount = _totalCoins - _activeCoins;
        _coinCounterText.text = _originalCoinCounterText + _playerCoinCount;
    }
}
