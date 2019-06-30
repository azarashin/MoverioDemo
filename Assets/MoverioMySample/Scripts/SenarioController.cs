using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// シナリオ制御用クラス
/// </summary>
public class SenarioController : MonoBehaviour
{
    /// <summary>
    /// シナリオを格納する配列。
    /// ページの切り替えが実行されると配列の参照先が変わる。
    /// 
    /// </summary>
    [SerializeField]
    GameObject[] _pages;

    /// <summary>
    /// 現在表示中のページ
    /// </summary>
    private int _currentPage = 0; 

    // Start is called before the first frame update
    void Start()
    {
        _currentPage = 0; 
        UpdatePage();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            NextPage(); 
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            PrevPage(); 
        }
        UpdatePage(); 

    }

    private void UpdatePage()
    {
        for (int i = 0; i < _pages.Length; i++)
        {
            _pages[i].SetActive(false);
        }
        if(_currentPage >= 0 && _currentPage < _pages.Length)
        {
            _pages[_currentPage].SetActive(true);
        }
    }

    public void NextPage()
    {
        if (_currentPage < _pages.Length - 1)
        {
            _currentPage++;
        }

    }

    public void PrevPage()
    {
        if (_currentPage > 0)
        {
            _currentPage--;
        }

    }
}
