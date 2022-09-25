using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DefaultTowerType", menuName = "RandomTower/TowerType", order = 2)]
public class TowerType : ScriptableObject
{
    //뽑는 위치에서 보여주는 이름
    public string displayName = "name";

    //스프라이트 이미지
    public Sprite icon;
}
