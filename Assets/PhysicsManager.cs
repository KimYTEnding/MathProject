using UnityEngine;

public class PhysicsManager : MonoBehaviour
{
    public Rigidbody sphere1;
    public Rigidbody sphere2;
    public Rigidbody sphere3;
    public Rigidbody sphere4;
    
    public void ApplyForce()
    {
        // �������� ���� ����
        sphere1.AddForce(new Vector2(10, 3), ForceMode.Force); // F=ma�� F �ο�
        sphere2.AddForce(new Vector2(10, 3), ForceMode.Acceleration); // ������ ���þ��� �ӵ��� �ο�
        // ��ȸ�� ���� ����
        sphere3.AddForce(new Vector2(10, 3), ForceMode.Impulse); // ���� ��� ��ȭ �ο�
        sphere4.AddForce(new Vector2(10, 3), ForceMode.VelocityChange); // ������ ���þ��� ���� �ӵ� �ο�
    }
}
