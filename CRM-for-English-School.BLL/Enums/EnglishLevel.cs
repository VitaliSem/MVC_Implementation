using System.ComponentModel.DataAnnotations;

namespace CRM_for_English_School.BLL.Entities
{
    public enum EnglishLevel
    {
        Elementary,
        PreIntermediate, //подчеркивание здесь не соответствует соглашениям кода C#
        Intermediate,
        UpperIntermediate,
        Advanced,
        Proficiency
    }
}