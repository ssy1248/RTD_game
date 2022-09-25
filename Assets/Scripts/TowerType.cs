using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DefaultTowerType", menuName = "RandomTower/TowerType", order = 2)]
public class TowerType : ScriptableObject
{
    //�̴� ��ġ���� �����ִ� �̸�
    public string displayName = "name";

    //��������Ʈ �̹���
    public Sprite icon;
}
