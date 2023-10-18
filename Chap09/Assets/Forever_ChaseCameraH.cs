using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ��� ī�޶� ���Ѿ� ����(��������)
public class Forever_ChaseCameraH : MonoBehaviour
{
	Vector3 base_pos;

	void Start() // ó���� �����Ѵ�
	{
		// ī�޶��� ���� ��ġ�� ����� �д�
		base_pos = Camera.main.gameObject.transform.position;
	}

	void LateUpdate() // ��� �����Ѵ�(���� ���� ó���� ��������)
	{
		Vector3 pos = this.transform.position; // �ڽ��� ��ġ
		pos.z = -10; // ī�޶��̹Ƿ� ������ �̵���Ų��
		pos.y = base_pos.y; // ī�޶� ������ ���̸� ����Ѵ�
		Camera.main.gameObject.transform.position = pos;
	}
}