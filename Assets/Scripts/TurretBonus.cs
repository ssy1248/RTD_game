using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�ͷ��� ���ʽ�
public enum TurretBonusType { Damage, Range, ShootCoolDown};

//�������� �ٰ�����
public enum BonusTarget { Self, Enemy};

public class TurretBonus : MonoBehaviour
{
    //���ʽ��� �޾ƾ� �ϴ� Ÿ���� ����?
    public int TurretCnt = 0;

    public TurretBonusType turretBonus;

    public BonusTarget bonusTarget;
}
