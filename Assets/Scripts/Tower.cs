using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DefaultTower", menuName = "RandomTower/Tower", order = 1)]
public class Tower : ScriptableObject
{
    //Ÿ�� ������
    public GameObject prefab;

    //���� �� ���� ������Ʈ
    public GameObject attackObject;

    //Ÿ�� �̸�
    public string TowerName;

    //Ÿ�� �ڽ�Ʈ
    public int cost;

    //Ÿ�� Ÿ�� 1
    public TowerType type1;

    //Ÿ�� Ÿ�� 2
    public TowerType type2;

    //Ÿ�� ������
    public float damage = 10;

    //���� ��Ÿ�
    public float attackRange = 1;
}
