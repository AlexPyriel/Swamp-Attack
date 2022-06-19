using UnityEngine;

public class Shotgun : Weapon
{
    [SerializeField] private float _spread;

    public override void Shoot(Transform shootPoint)
    {
        Vector3 spreadPositionUp = new Vector3(shootPoint.position.x, shootPoint.position.y + _spread, shootPoint.position.z);
        Vector3 spreadPositionDown = new Vector3(shootPoint.position.x, shootPoint.position.y - _spread, shootPoint.position.z);

        Instantiate(Bullet, shootPoint.position, Quaternion.identity);
        Instantiate(Bullet, spreadPositionUp, Quaternion.identity);
        Instantiate(Bullet, spreadPositionDown, Quaternion.identity);
    }
}
