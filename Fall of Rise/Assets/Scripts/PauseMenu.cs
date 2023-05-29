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
            //name - имя персонажа
    DataClass.scene = "";
    //name - название сцены
    DataClass.name = "";
    //intellect - уровень интеллекта
    DataClass.intellect = 0;
    //brave - смелость
    DataClass.brave = 0;
    //relation - отношение с мамой
    DataClass.relation = 0;
    //пол персонажа - для вставки подходящей картинки в диалогах 
    DataClass.gender = "W";
    //конец диалога на сцене с комнатой
    DataClass.endDialogue = 0;
    //запрет на движение
    DataClass.move = 0;
    //когда двигаешься move = 0
    //когда недвигаешься move = 1
    //является ли гг куратором или нет
    DataClass.is_cur = false;
    //диалоги
    //choose_conversation_mommy - диалог с мамой
    DataClass.choose_conversation_mommy = 1; //начинаем с 1, чтобы первый диалог точно активировался
                                        //choose_conversation_tutor - диалог с куратором
    DataClass.choose_conversation_tutor = 0; //начинаем с 0, идет +1 после активации вставки с заданием пройти в корпус
    //choose_conversation_O2 - диалог с Васькой
    DataClass.choose_conversation_O2 = 0; //начинаем с 0, идет +1 после разговора с кураторшей
    DataClass.choose_conversation_O2EKZ = 0; //разговор с Васей на сцене экзамена, сделала отдельно, чтобы быстрее проводить проверки
                                        //choose_conversation_O2 - диалог с Владом
    DataClass.choose_conversation_O1 = 0;
    //choose_conversation_O3 - диалог с Ириной
    DataClass.choose_conversation_O3 = 0;
    //choose_conversation_igor - диалог с Игорем
    DataClass.choose_conversation_igor = 0;
    //choose_conversation_TF - диалог с Токсиньей Федоровной
    DataClass.choose_conversation_TF = 0;
    DataClass.choose_conversation_TF2 = 0; //на второй сцене, мы ж разделили

    //облака
    //на сцене HomePlayer
    DataClass.off_cloud1 = false;
    //на сцене 14Frame
    DataClass.off_cloud_krossword = false;
    //на сцене HostelForRun
    DataClass.off_cloud_hfr = false;
    DataClass.off_cloud_igor = false;
    DataClass.on_bed = false;

    //для пазлов
    DataClass.count_elements = 0;

    //перенос со сцены cutscene на сцену homeplayer
    DataClass.trans_on = false;

    //для отслеживания зон
    DataClass.zone_num = 0;

    //для показа концовки
    DataClass.final_anim = 0;
} 
    } 
}
