using UnityEngine;

public class PhysicsManager : MonoBehaviour
{
    public Rigidbody sphere1;
    public Rigidbody sphere2;
    public Rigidbody sphere3;
    public Rigidbody sphere4;
    
    public void ApplyForce()
    {
        // 지속적인 힘을 가함
        sphere1.AddForce(new Vector2(10, 3), ForceMode.Force); // F=ma의 F 부여
        sphere2.AddForce(new Vector2(10, 3), ForceMode.Acceleration); // 질량과 관련없이 속도만 부여
        // 일회성 힘을 가함
        sphere3.AddForce(new Vector2(10, 3), ForceMode.Impulse); // 순간 운동량 변화 부여
        sphere4.AddForce(new Vector2(10, 3), ForceMode.VelocityChange); // 질량과 관련없이 순간 속도 부여
    }
}
