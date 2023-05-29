using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
     
    void Update() 
    { 
        if (Input.GetKeyDown(KeyCode.Escape)) 
        { 
            SceneManager.LoadScene("Menu");
            //name - ��� ���������
    DataClass.scene = "";
    //name - �������� �����
    DataClass.name = "";
    //intellect - ������� ����������
    DataClass.intellect = 0;
    //brave - ��������
    DataClass.brave = 0;
    //relation - ��������� � �����
    DataClass.relation = 0;
    //��� ��������� - ��� ������� ���������� �������� � �������� 
    DataClass.gender = "W";
    //����� ������� �� ����� � ��������
    DataClass.endDialogue = 0;
    //������ �� ��������
    DataClass.move = 0;
    //����� ���������� move = 0
    //����� ������������ move = 1
    //�������� �� �� ��������� ��� ���
    DataClass.is_cur = false;
    //�������
    //choose_conversation_mommy - ������ � �����
    DataClass.choose_conversation_mommy = 1; //�������� � 1, ����� ������ ������ ����� �������������
                                        //choose_conversation_tutor - ������ � ���������
    DataClass.choose_conversation_tutor = 0; //�������� � 0, ���� +1 ����� ��������� ������� � �������� ������ � ������
    //choose_conversation_O2 - ������ � �������
    DataClass.choose_conversation_O2 = 0; //�������� � 0, ���� +1 ����� ��������� � ����������
    DataClass.choose_conversation_O2EKZ = 0; //�������� � ����� �� ����� ��������, ������� ��������, ����� ������� ��������� ��������
                                        //choose_conversation_O2 - ������ � ������
    DataClass.choose_conversation_O1 = 0;
    //choose_conversation_O3 - ������ � ������
    DataClass.choose_conversation_O3 = 0;
    //choose_conversation_igor - ������ � ������
    DataClass.choose_conversation_igor = 0;
    //choose_conversation_TF - ������ � ��������� ����������
    DataClass.choose_conversation_TF = 0;
    DataClass.choose_conversation_TF2 = 0; //�� ������ �����, �� � ���������

    //������
    //�� ����� HomePlayer
    DataClass.off_cloud1 = false;
    //�� ����� 14Frame
    DataClass.off_cloud_krossword = false;
    //�� ����� HostelForRun
    DataClass.off_cloud_hfr = false;
    DataClass.off_cloud_igor = false;
    DataClass.on_bed = false;

    //��� ������
    DataClass.count_elements = 0;

    //������� �� ����� cutscene �� ����� homeplayer
    DataClass.trans_on = false;

    //��� ������������ ���
    DataClass.zone_num = 0;

    //��� ������ ��������
    DataClass.final_anim = 0;
} 
    } 
}
