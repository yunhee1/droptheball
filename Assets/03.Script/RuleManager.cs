using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RuleManager : MonoBehaviour
{
    public static RuleManager _instance;
    /// <summary>
    /// ��ŲŸ��
    /// </summary>
    public enum BallType
    {
        Balls = 0,
        sdfS
    }
    public static int _maxLevel = 8;            // ���� �ִ� ����
    public BallType _ballType;                  // ���� Ÿ��
    public List<Material> _balls;               // ���� ���۽� ���� ��Ų�� ��Ƽ����
    public static float _reloadTime = 1;        // ���� ���� �ð�
    public int _score;
    // �ӽ�
    private void Awake()
    {
        _instance = this;
        Material[] go = Resources.LoadAll<Material>(_ballType.ToString());
        for (int i = 0; i < go.Length; i++)
        {
            _balls.Add(go[i]);
        }
    }
}