using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIMinimap : MonoBehaviour
{
    [SerializeField]
    private Camera minimapCamera; // �̴ϸ� ī�޶�
    [SerializeField]
    private float zoomMin = 1; // �̴ϸ� �ּҰ�
    [SerializeField]
    private float zoomMax = 30; // �̴ϸ� �ִ밪
    [SerializeField]
    private float zoomOneStep = 1; // �̴ϸ� ��� Ȯ�� ����
    [SerializeField]
    private TextMeshProUGUI textMapName;
    //SceneManager.GetActiveScene().name; // ���� ���� �̸�
    //orthographicsize ����׷��� ī�޶��� ������
    private void Awake()
    {
        //�� �̸��� ���� �� �̸����� ����
        textMapName.text = SceneManager.GetActiveScene().name;
    }
    public void ZoomIn()
    {
        minimapCamera.orthographicSize = Mathf.Max(minimapCamera.orthographicSize - zoomOneStep, zoomMin);
        //ī�޶��� orthographicSize ���� ���ҽ��� ī�޶� ���̴� �繰 ũ�� Ȯ��
    }
    public void ZoomOut()
    {
        minimapCamera.orthographicSize = Mathf.Min(minimapCamera.orthographicSize + zoomOneStep, zoomMax);
        //ī�޶��� orthographicSize ���� �������� ī�޶� ���̴� �繰 ũ�� ���
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
