using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DefaultTower", menuName = "RandomTower/Tower", order = 1)]
public class Tower : ScriptableObject
{
    //타워 프리팹
    public GameObject prefab;

    //공격 시 날라갈 오브젝트
    public GameObject attackObject;

    //타워 이름
    public string TowerName;

    //타워 코스트
    public int cost;

    //타워 타입 1
    public TowerType type1;

    //타워 타입 2
    public TowerType type2;

    //타워 데미지
    public float damage = 10;

    //공격 사거리
    public float attackRange = 1;
}
